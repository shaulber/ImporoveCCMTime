using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;

namespace ImproveCCMUploadTime
{
    public class Model1
    {

        private const string ParentIdSortKey = "ParentID" + " ASC";
        private List<NodeItem> _nodeItems;
        public DataSet DSModel { get; private set; }
        public DataTable Dt { get; private set; }

        public Dictionary<string, int> CTMList { get; set; }

        private readonly Dictionary<string, int> _keysIds = new Dictionary<string, int>();
        public Model1()
        {
            DSModel = new DataSet("Model") {CaseSensitive = true};
            _nodeItems = new List<NodeItem>();
            InitDataTable();
            InitDataSet();
            InitModel();
        }

        private void InitModel()
        {
            int nodeId = 1;
            XmlNodeList nodeList = GetNodeList(MockData.XmlBody);
            if (nodeList != null)
            {
                FillNodeItemList(nodeList, _nodeItems, true);
                Dt.BeginLoadData();

                foreach (var comp in _nodeItems)
                {
                    AddComponent(new CCMModelItem(comp.XmlNode), ref nodeId);                   
                }
                try
                {
                    Dt.EndLoadData();
                }
                catch
                {
                }
            }
        }

        private DataRow AddComponent(CCMModelItem ccmModelItem, ref int nodeId)
        {
            var dr = Dt.NewRow();
            dr["ID"] = ++nodeId;

            var key = ccmModelItem.ComponentKey.ToString();

            if (_keysIds.ContainsKey(key)) return dr;
           // _keysIds[key] = (int)dr["ID"];
            _keysIds[key] = ++nodeId; ;

            UpdateDataRowFromModelItem(dr, ccmModelItem);

            Dt.Rows.Add(dr);
            return dr;
        }

        private void UpdateDataRowFromModelItem(DataRow dr, CCMModelItem modelItem)
        {
            var componentKey = modelItem.ComponentKey;
            var attributes = modelItem.Attributes;

            dr["Type"] = componentKey.Type;
            dr["Name"] = componentKey.Name;
            dr["Host"] = componentKey.Host;
            dr["NodeID"] = componentKey.NodeId;
            dr["ApplType"] = componentKey.ApplType;
            dr["ApplVersion"] = componentKey.ApplVer;
            dr["CMVer"] = componentKey.CMVer;
            dr["Extension"] = componentKey.Extension;
            dr["CurrentState"] = attributes.CurrentState;
            dr["DesiredState"] = attributes.DesiredState;
            dr["LastUpdate"] ="19/19/19";
            dr["Status"] = attributes.Status;
            dr["StatusMessage"] = "Message";
            dr["OSType"] = attributes.OSType;
            dr["Version"] = attributes.Version;

            dr["PrimaryHost"] = attributes.DBHost;
            dr["PrimaryHost"] = attributes.PrimaryHost;
            dr["SecondaryHost"] = attributes.SecondaryHost;
            dr["PrimaryDBHost"] = attributes.PrimaryDBHost;
            dr["SecondaryDBHost"] = attributes.SecondaryDBHost;
            dr["AdminAgentStatus"] = attributes.AdminAgentStatus;
            dr["DisplayedType"] = modelItem.ComponentKey.Type;

            dr["AdditionalAttributes"] = attributes.AdditionalAttributes;
            dr["ComponentItem"] = modelItem;
            dr["TreeDisplayName"] = "TreeDisplayName";
            dr["GridDisplayName"] = "GridDisplayName";
            dr["GridDisplayDBHost"] = attributes.DBHost;
            dr["GridDisplayHost"] = attributes.PrimaryHost;
            dr["GridDisplayMessage"] = "Message";
            dr["CurrentStateString"] = attributes.CurrentState;
            dr["EntryNodeType"] ="";
            dr["StatusString"] = attributes.Status;
        }

        private void FillNodeItemList(XmlNodeList nodeList, List<NodeItem> nodeItems, bool removeDuplicates)
        {

            nodeItems.Clear();
            nodeItems.AddRange(nodeList.Cast<XmlNode>().Select(xmlNode => new NodeItem(xmlNode)));
            nodeItems.Sort(new NodeCompare());

            //--- remove duplicate keys from list
            if (removeDuplicates)
            {
                RemoveDuplicateKeys(nodeItems);
            }
        }

        private void RemoveDuplicateKeys(List<NodeItem> list)
        {

            var sErrMsg = "There are duplicate keys:\n";

            //--- assuming list is sorted by key, so duplicate keys are adjacent
            if (list.Count > 1)
            {
                var i = 1;
                var iCount = list.Count;
                while (i < iCount)
                {
                    if (list[i - 1].Key == list[i].Key)
                    {
                        var errorParams = new ArrayList { list[i - 1].ToString() };

                       

                        //for the log
                        sErrMsg += list[i - 1].ToString();
                        sErrMsg += "\n";

                        list.RemoveAt(i - 1);
                        --iCount;
                    }
                    else
                        ++i;
                }
            }
           
        }

        private void LoadTreeData()
        {

            try
            {
                CTMList = Dt.Rows.Cast<DataRow>()
                    .Where(r => Equals(r["Type"], "CTM_erver"))
                    .ToDictionary(r => (string)r["Name"], r => (int)r["ID"]);
                Dt.BeginLoadData();
                UpdateComponentsParents();
               // AddFakeEMDatabases(Dt);
                AddRootNode( true ? "All Computers" : "Main Computer");
                if (true)
                {
                    var nodeId = GetMaxId(Dt);
                    var hosts = AddHostNodes(Dt, ref nodeId);
                    AddAlternativeHosts(Dt, hosts, ref nodeId);
                }
                UpdateParentPaths(Dt);
               // UpdateFakeParentPaths(Dt);
                SetTreeTableStatuses(Dt);

                Dt.EndLoadData();
            }
            catch (Exception e)
            {
                var sMsg = string.Format("Failed to enforce Type tree table constraints on Init: {0}", e.Message);
            }
        }

        private void SetTreeTableStatuses(DataTable dataTable)
        {

            // root entries
            var dataView = new DataView(dataTable)
            {
                Sort = ParentIdSortKey,
                RowFilter ="ParentID" + " = " + 1
            };

            // root entries for the recursion of the statuses
            var rootEntries = new DataView(dataTable) { Sort = ParentIdSortKey };

            foreach (DataRowView rowView in dataView)
            {
                var nodeWorstStatus = SetTreeTableStatuses(rootEntries, rowView.Row);
               // rowView[TreeImageIndex] = StatusTreeIconIndex(nodeWorstStatus);
            }

           // TreeStatusesNeedUpdate = false;
        }

        private int? SetTreeTableStatuses(DataView rootEntries, DataRow root)
        {
            int? worstStatus;
            var rootType = root["Type"] as string;

            var tempRootEntries = rootEntries.FindRows((int)root["ID"]);

            var hasChildren = tempRootEntries.Length > 0;

            if (hasChildren) // are there any child nodes?
            {
                // go recursively over all children and update their statuses
                worstStatus = tempRootEntries.Select(entry => SetTreeTableStatuses(rootEntries, entry.Row))
                    .Aggregate((int?)0, (current, nodeWorstStatus) => current.HasValue && nodeWorstStatus.HasValue ? (int?)Math.Max(current.Value, nodeWorstStatus.Value) : null);

                // if all OK and root is CTM/Server or Agent, then its status
                // should also be tested
                if (worstStatus.HasValue && worstStatus.Value == 0 &&
                    ("CTM_Server" == rootType || "CTM_Agent" == rootType || "EM"== rootType))
                {
                    worstStatus = 3;
                }
            }
            else if ((NodeEntryType)root["EntryNodeType"] == NodeEntryType.FakeComponent
                     && ("CTM_Server" == rootType || "EM" == rootType))
            {
                worstStatus = null;
            }
            else // leaf
            {
                worstStatus = 2;
            }

            // set this node status icon
           // root["TreeImageIndex"] = StatusTreeIconIndex(worstStatus);

            return worstStatus;
        }
        private void UpdateParentPaths(DataTable dataTable)
        {
            var dataView = new DataView(dataTable) { Sort = ParentIdSortKey };
            RecursiveUpdateParentPaths(dataView, null);
        }
        private static void RecursiveUpdateParentPaths(DataView dataView, DataRowView parentRow)
        {
            var parentId = parentRow == null ? 1 : parentRow["ID"];
            var parentRowParentPath = parentRow == null ? null : (string)parentRow["ParentPath"];
            var parentPath = string.IsNullOrEmpty(parentRowParentPath)
                ? parentId.ToString()
                : parentRowParentPath + "-" + parentId;

            var rows = dataView.FindRows(parentId);
            foreach (var row in rows)
            {
                row["ParentPath"] = parentPath;
                RecursiveUpdateParentPaths(dataView, row);
            }
        }

        private void AddAlternativeHosts(DataTable dataTable, Dictionary<string, HostDetails> hosts, ref int nodeId)
        {

            var emAndCTMSView = new DataView(dataTable)
            {
                RowFilter = "Type" + " = '" + "EM"+ "' OR "
                            + "Type" + " = '" + "CTM_erver" + "'"
            };

            var dataView = new DataView(dataTable) { Sort = ParentIdSortKey };

            foreach (DataRowView row in emAndCTMSView)
            {
                var host = row["Host"] as string;
                var primary = row["PrimaryHost"] as string;
                var secondary = row["SecondaryHost"] as string;
               
            }
        }
        private void AddHostNode(DataTable table, string host, int nodeId)
        {
          
            // create a data row for the Tree table
            var dr = table.NewRow();

            dr["ID"] = nodeId;
            dr["ParentID"] =1;
            dr["EntryNodeType"] = NodeEntryType.Host;
            dr["Name"] = host;
            dr["TreeDisplayName"] = host;
            dr["GridDisplayName"] = host;
            dr["Type"] = string.Empty;
            dr["Host"] = host;
            dr["NodeID"] = string.Empty;
            dr["ApplType"] = string.Empty;
            dr["ApplVersion"] = string.Empty;
            dr["CMVer"] = string.Empty;
            dr["Extension"] = string.Empty;

            table.Rows.Add(dr);
        }
        private void AddHostRow(DataView dataView, DataRow row, ref int nodeId,
            IDictionary<string, HostDetails> hosts, string host, int rowId)
        {
            HostDetails hostDetails;
            if (hosts.TryGetValue(host, out hostDetails))
            {
                hostDetails.Nodes.Add(rowId);
                row["ParentID"] = hostDetails.Id;
            }
            else
            {
                AddHostNode(dataView.Table, host, ++nodeId);
                hosts[host] = new HostDetails { Id = nodeId, Nodes = new HashSet<int> { rowId } };
                row["ParentID"] = nodeId;
            }
        }
        private void RecursiveAddHostNodes(DataView dataView, DataRowView row, ref int nodeId, Dictionary<string, HostDetails> hosts)
        {
            var rowId = row == null ? 1 : (int)row["ID"];
            if (row != null)
            {
                if ((NodeEntryType)row["EntryNodeType"] == NodeEntryType.FakeComponent) return;
                var modelItem = row["ComponentItem"] as CCMModelItem;
                if (modelItem != null)
                {
                    var host = modelItem.ComponentKey.Host;
                    AddHostRow(dataView, row.Row, ref nodeId, hosts, host, rowId);
                }
            }

            var childRows = dataView.FindRows(rowId);
            foreach (var childRow in childRows)
            {
                RecursiveAddHostNodes(dataView, childRow, ref nodeId, hosts);
            }
        }
        private  Dictionary<string, HostDetails> AddHostNodes(DataTable dataTable, ref int nodeId)
        {
            var hosts = new Dictionary<string, HostDetails>();
            var dataView = new DataView(dataTable) { Sort = ParentIdSortKey };
            RecursiveAddHostNodes(dataView, null, ref nodeId, hosts);
            return hosts;
        }
        private  IEnumerable<DataRow> GetTableRows(DataTable table)
        {
            return table.Rows.Cast<DataRow>().Where(dr => dr.RowState != DataRowState.Deleted);
        }
        private int GetMaxId(DataTable dt)
        {
            return dt == null ? 1
                : GetTableRows(dt).Select(dr => (int)dr["ID"])
                    .DefaultIfEmpty(1) // during  faillover/fallback, all componets might be deleted, so in order for Max() not to fail, we use DefaultIfEmpty.
                    .Max();
        }


        private void AddRootNode( string displayName)
        {
            var dr = Dt.NewRow();
            // create a data row for the Tree table
            dr["ID"] = 1;
            dr["EntryNodeType"] =0;
            dr["Name"] = displayName;
            dr["TreeDisplayName"] = displayName;
            dr["GridDisplayName"] = displayName;
            dr["TreeImageIndex"] = 46;
            dr["Type"] = string.Empty;
            dr["Host"] = string.Empty;
            dr["NodeID"] = string.Empty;
            dr["ApplType"] = string.Empty;
            dr["ApplVersion"] = string.Empty;
            dr["CMVer"] = string.Empty;
            dr["Extension"] = string.Empty;

            Dt.Rows.InsertAt(dr, 0); // we want root node to be first line in data table, so refresh doesn't expand into another node in the tree, in the short time until we restore selection.
        }
        private void UpdateComponentsParents()
        {
            foreach (DataRow dr in Dt.Rows)
            {
                dr["ParentID"] = GetComponentParent(dr);
                dr["TreeDisplayName"] = dr["Name"];
            }
        }

       
        private int GetComponentParent(DataRow dr)
        {
            var modelItem = dr["ComponentItem"] as CCMModelItem;
            if (modelItem == null || modelItem.ParentComponentKey == null) return 1;
            int parentID;
            return _keysIds.TryGetValue(modelItem.ParentComponentKey.ToString(), out parentID) ? parentID : 1;
        }


        private XmlNodeList GetNodeList(XmlNode xmlBody)
        {
            return xmlBody == null ? null : xmlBody.SelectNodes("//Component");
        }

        private void InitDataTable()
        {
            Dt = new DataTable("MyTable");

            Dt.Columns.Add("Type", typeof(string));
            Dt.Columns.Add("Name", typeof(string));
            Dt.Columns.Add("Host", typeof(string));
            Dt.Columns.Add("NodeID", typeof(string));
            Dt.Columns.Add("ApplType", typeof(string));
            Dt.Columns.Add("ApplVersion", typeof(string));
            Dt.Columns.Add("CMVer", typeof(string));
            Dt.Columns.Add("Extension", typeof(string));

            Dt.Columns.Add("CurrentState", typeof(string));
            Dt.Columns.Add("DesiredState", typeof(string));
            Dt.Columns.Add("LastUpdate", typeof(string));
            Dt.Columns.Add("Status", typeof(string));
            Dt.Columns.Add("StatusMessage", typeof(string));
            Dt.Columns.Add("OSType", typeof(string));
            Dt.Columns.Add("Version", typeof(string));
            Dt.Columns.Add("AdminAgentStatus", typeof(string));
            Dt.Columns.Add("DisplayeDtype", typeof(string));
            Dt.Columns.Add("DBHost", typeof(string));
            Dt.Columns.Add("PrimaryHost", typeof(string));
            Dt.Columns.Add("SecondaryHost", typeof(string));
            Dt.Columns.Add("PrimaryDBHost", typeof(string));
            Dt.Columns.Add("SecondaryDBHost", typeof(string));

            Dt.Columns.Add("ComponentItem", typeof(string));
            Dt.Columns.Add("ID", typeof(string));
            Dt.Columns.Add("ParentID", typeof(string));
            Dt.Columns.Add("ParentPath", typeof(string));
            Dt.Columns.Add("FakeParentPath", typeof(string));
            Dt.Columns.Add("EntryNodeType", typeof(string));
            Dt.Columns.Add("TreeDisplayName", typeof(string));
            Dt.Columns.Add("GridDisplayName", typeof(string));
            Dt.Columns.Add("GridDisplayHost", typeof(string));
            Dt.Columns.Add("GridDisplayDBHost", typeof(string));
            Dt.Columns.Add("GridDisplayMessage", typeof(string));
            Dt.Columns.Add("CurrentStateString", typeof(string));
            Dt.Columns.Add("StatusString", typeof(string));
            Dt.Columns.Add("TreeImageIndex", typeof(string));

            Dt.Columns.Add("AdditionalAttributes");

            var keys = new[]
            {
                Dt.Columns["Type"],
                Dt.Columns["Name"],
                Dt.Columns["Host"],
                Dt.Columns["NodeID"],
                Dt.Columns["ApplType"],
                Dt.Columns["ApplVersion"],
                Dt.Columns["CMVer"],
                Dt.Columns["Extension"]
            };

            Dt.PrimaryKey = keys;
        }

        private void InitDataSet()
        {
            DSModel.Tables.Add(Dt);
        }
    }
    
    internal enum NodeEntryType
    {
        Root,
        Component,
        FakeComponent, // component we duplicate in the tree, like EM database, or secondary CTMS/EM
        Host
    }

    internal class HostDetails
    {
        public int Id;
        public HashSet<int> Nodes;
    }
    internal class NodeCompare : IComparer<NodeItem>
    {
        public int Compare(NodeItem x, NodeItem y)
        {
            return string.Compare(x.Key, y.Key, StringComparison.Ordinal);
        }
    }
}