using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using DevExpress.Export;
using DevExpress.XtraTreeList.Nodes;
using ImproveCCMUploadTime.model;
using ImproveCCMUploadTime.Model;

namespace ImproveCCMUploadTime
{
    public partial class AfterForm : Form

    {

        private Topology result;
        private DataTable dt = new DataTable();
        public AfterForm()
        {
            InitializeComponent();
            InitDT();

        }

        private void InitDT()
        {
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Type");
            dt.Columns.Add("Name");
            dt.Columns.Add("Host");
            dt.Columns.Add("DBHost");
            dt.Columns.Add("Primaryhost");
            dt.Columns.Add("SecondaryHost");
            dt.Columns.Add("ParimaryDbHost");
            dt.Columns.Add("SecondaryDBHost");
            dt.Columns.Add("State");
            dt.Columns.Add("DesiredState");
            dt.Columns.Add("Message");
            dt.Columns.Add("LastChecked");
            dt.Columns.Add("OS");
            dt.Columns.Add("Version");
            dt.Columns.Add("HasHa");
        }

     
        private void AfterForm_Load(object sender, EventArgs e)
        {

            var xmlDoc = new XmlDocument();
            string bodyEl = XDocument.Parse(MockData.Response).Descendants("Get_components_response").First()
                .ToString();

            XmlSerializer serializer = new XmlSerializer(typeof(Topology));

            try
            {
                using (TextReader reader = new StringReader(bodyEl))
                {
                    result = (Topology) serializer.Deserialize(reader);

                    treeList1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void treeList1_VirtualTreeGetCellValue(object sender,
            DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo e)
        {
            e.CellData = ((Component) e.Node).ToString();
        }

        private void treeList1_VirtualTreeGetChildNodes(object sender,
            DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo e)
        {
            if (e.Node.GetType() == typeof(Topology))
                e.Children = ((Topology) e.Node).Components;
            else if (e.Node.GetType() == typeof(Component))
                e.Children = ((Component) e.Node).Sub_components;
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            _mainGrid.ClearSelection();
            dt.Clear();
            var focused = (Component)treeList1.GetFocusedRow();
            dt.Rows.Add(AddRow(focused));
            foreach (Component component in focused.Sub_components)
            {
               dt.Rows.Add(AddRow(component));
                
            }

            gridControl1.DataSource = dt;
            _mainGrid.PopulateColumns();
        }

        private DataRow AddRow(Component component)
        {
            DataRow dr = dt.NewRow();

            dr["Status"] = component.Attributes.CurrentState;
            dr["Type"] = component.ComponentKey.Type;
            dr["Name"] = component.ComponentKey.Name;
            dr["Host"] = component.ComponentKey.Host;
            dr["DBHost"] = "";
            dr["Primaryhost"] = ""; 
             dr["SecondaryHost"] =""; 
             dr["ParimaryDbHost"] = ""; 
             dr["SecondaryDBHost"] = ""; 
            dr["State"] = component.Attributes.CurrentState; 
             dr["DesiredState"] = "";
            dr["Message"] = "";
             dr["LastChecked"] = ""; 
             dr["OS"] = component.Attributes.OSType;
            dr["Version"] = component.Attributes.Version; 
            dr["HasHa"] =""; 
            return dr;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        
        private void treeList1_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            Component component = (Component)e.Node.TreeList.GetDataRecordByNode(e.Node);
            e.NodeImageIndex = ComponentResources.Instance.getStateImageIndex(component.Attributes.CurrentState);
        }
        
    }
}

