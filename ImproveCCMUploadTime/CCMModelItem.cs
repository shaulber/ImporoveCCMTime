using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using DevExpress.Xpo.Logger;

namespace ImproveCCMUploadTime
{
    public class CCMModelItem : IComparable
    {

        public const String NoValue = "";

        public CCMModelItemKey ComponentKey { get; set; }

        public components_attributes_type Attributes { get; set; }

        public CCMModelItemKey ParentComponentKey { get; set; }

        public Boolean NewHaProgress { get; set; }

        /// <summary>
        /// Transform a Model item key to a schema component key
        /// </summary>
        public componentKey_type CCMApiComponentKey
        {
            get
            {
                return ComponentKey.ToCCMApiComponentKey();
            }
        }

        public void UpdateParentComponentKey(XmlNode xmlNode)
        {
            Debug.Assert(xmlNode != null, "_xmlNode is not initialized");

            var parentComponentKey = xmlNode.SelectSingleNode("../../" + "ComponentKey");
            if (parentComponentKey != null)
            {
                ParentComponentKey = new CCMModelItemKey(parentComponentKey);
            }
        }



        public CCMModelItem(XmlNode xmlNode)
        {
            UpdateParentComponentKey(xmlNode);

            var nodeList = xmlNode.ChildNodes;

            foreach (XmlNode node in nodeList)
            {
                switch (node.Name)
                {
                    case "ComponentKey":
                        ComponentKey = new CCMModelItemKey(node);
                        break;
                    case "Attributes":
                        string xml = null;
                        try
                        {
                            xml = string.Format("<{0}>{1}</{0}>", typeof(components_attributes_type).Name, node.InnerXml);
                            Attributes = DeserializeXML<components_attributes_type>(xml);

                            // we need to trim values, as they might not be trimmed in the XML
                            Attributes.CurrentState = TrimIfNeeded(Attributes.CurrentState);
                            Attributes.DesiredState = TrimIfNeeded(Attributes.DesiredState);
                            Attributes.Status = TrimIfNeeded(Attributes.Status);
                            //Attributes.StatusMessage = TrimIfNeeded(Attributes.StatusMessage);
                            Attributes.OSType = TrimIfNeeded(Attributes.OSType);
                            Attributes.Version = TrimIfNeeded(Attributes.Version);
                            Attributes.AdminAgentStatus = TrimIfNeeded(Attributes.AdminAgentStatus);
                        }
                        catch (Exception ex)
                        {
                            Attributes = new components_attributes_type
                            {
                                Status = "3",
                              //  StatusMessage = GetXMLNodeErrorMessage(ex, xml),
                            };
                        }
                        break;
                    //case CCMSchemaTags.TAG_Sub_components:
                        // do nothing - we only keep reference to its parent
                        break;

                    default:
                        break;
                }
            }

            if (ComponentKey == null) ComponentKey = new CCMModelItemKey();
        }

        public static TResponseType DeserializeXML<TResponseType>(string xml) where TResponseType : class
        {
            #region logger

         
            #endregion logger

            var xs = new XmlSerializer(typeof(TResponseType));
            // add handlers for unknown nodes and attributes
          //  xs.UnknownNode += serializer_UnknownNode;
         //   xs.UnknownAttribute += serializer_UnknownAttribute;

            try
            {
                var res = xs.Deserialize(new StringReader(xml)) as TResponseType;

            }
            catch (Exception ex)
            {

                

            }
            return xs.Deserialize(new StringReader(xml)) as TResponseType;
        }

        private static string TrimIfNeeded(string s)
        {
            return s == null ? null : s.Trim();
        }

        private static string GetXMLNodeErrorMessage(Exception exception, string xml)
        {
            var defaultErrorMessage = "Failed to read components attributes: " + exception.Message;
            try
            {
                if (!(exception is InvalidOperationException)) return defaultErrorMessage;

                // we expect the exception message to be in a format similar to:
                //      There is an error in XML document (1, 674).
                // but it might be in other languages, so we just look for the parenthesis.
                const string openingTerm = " (1, ";
                var pos = exception.Message.IndexOf(openingTerm, StringComparison.Ordinal);
                if (pos <= 0) return defaultErrorMessage;
                pos += openingTerm.Length;
                var lastPos = exception.Message.IndexOf(")", pos, StringComparison.Ordinal);
                var errorPosStr = exception.Message.Substring(pos, lastPos - pos);
                int errorPos;
                if (!int.TryParse(errorPosStr, out errorPos)) return defaultErrorMessage;
                errorPos -= 2; // for some reason, XML error reports the position in offset of 2.
                xml = xml.Substring(0, errorPos);
                var elementStart = xml.LastIndexOf("<", StringComparison.Ordinal);
                while (elementStart > 0 && xml[elementStart + 1] == '/')
                {
                    elementStart = xml.Substring(0, elementStart - 1).LastIndexOf("<", StringComparison.Ordinal);
                }

                return elementStart <= 0
                    ? defaultErrorMessage
                    : "Failed to read components attributes. Problematic element: " + xml.Substring(elementStart);

            }
            catch (Exception ex)
            {
                return defaultErrorMessage;
            }
        }

      
        public const string AndPauseSuffix = " and Pause";
        //public const string IgnoredSuffix = " (Ignored)";

        /// <summary>
        /// Gets the current state to display, taking into account Ignored state and Pause state.
        /// </summary>
       

        private static string GetAttrInnerText(XmlNode node, string innerAttrName)
        {
            var nameAttribute = node.SelectSingleNode(innerAttrName);
            return nameAttribute == null ? null : nameAttribute.InnerText;
        }

        private static string GetAttrName(XmlNode node)
        {
            return GetAttrInnerText(node, "Name");
        }

        private static string GetAttrValue(XmlNode node)
        {
            return GetAttrInnerText(node, "Value");
        }

        public bool IsTypeOf(String type)
        {
            return ComponentKey.Type == type;
        }

        #region ICCMContext Methods

        public ItemKey Key
        {
            get
            {
                return new ItemKey
                {
                    m_Type = ComponentKey.Type,
                    m_Name = ComponentKey.Name,
                    m_Host = ComponentKey.Host,
                    m_NodeID = ComponentKey.NodeId,
                    m_ApplType = ComponentKey.ApplType,
                    m_ApplVer = ComponentKey.ApplVer,
                    m_CMVer = ComponentKey.CMVer,
                    m_Extension = ComponentKey.Extension
                };
            }
        }



         

        public override String ToString()
        {
            var str = "CCMModelItem Data:\n";

            try
            {
                str += ComponentKey.ToString();
                str += Attributes.ToString();
            }
            catch (Exception e)
            {
                var sMsg = String.Format("Failed to print CCMModelItem contents: {0}", e.Message);
            }

            return str;
        }

        #endregion

        #region IComparable Members

        public int CompareTo(object obj)
        {
            var other = (CCMModelItem)obj;

            return ComponentKey.CompareTo(other.ComponentKey);
        }

        #endregion
    }

    public partial class components_attributes_type
    {

        private string currentStateField;

        private string desiredStateField;

        private string lastUpdateField;

        private string adminAgentStatusField;

        private string statusField;

        private string statusMessageField;

        private string oSTypeField;

        private string versionField;

        private string dBTypeField;

        private string primaryHostField;

        private string secondaryHostField;

        private string dBHostField;

        private string primaryDBHostField;

        private string secondaryDBHostField;

        private string hasHighAvailabilityField;

        private string dBHasHighAvailabilityField;

        private string failOverModeField;

        private string isDBManagerField;

        private string pauseField;

        private bool failoverStatusFieldSpecified;

        private bool dBFailoverStatusFieldSpecified;


        private bool nonActiveCAStatusFieldSpecified;


        private bool replicationStatusFieldSpecified;


        private bool replicationModeFieldSpecified;

        private string lastReplicationTimeField;

        private string[] notSyncedFilesField;


        private attribute_type[] additionalAttributesField;

        /// <remarks/>
        public string CurrentState
        {
            get
            {
                return this.currentStateField;
            }
            set
            {
                this.currentStateField = value;
            }
        }

        /// <remarks/>
        public string DesiredState
        {
            get
            {
                return this.desiredStateField;
            }
            set
            {
                this.desiredStateField = value;
            }
        }

        /// <remarks/>
        public string AdminAgentStatus
        {
            get
            {
                return this.adminAgentStatusField;
            }
            set
            {
                this.adminAgentStatusField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

      
        /// <remarks/>
        public string OSType
        {
            get
            {
                return this.oSTypeField;
            }
            set
            {
                this.oSTypeField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string PrimaryHost
        {
            get
            {
                return this.primaryHostField;
            }
            set
            {
                this.primaryHostField = value;
            }
        }

        /// <remarks/>
        public string SecondaryHost
        {
            get
            {
                return this.secondaryHostField;
            }
            set
            {
                this.secondaryHostField = value;
            }
        }

        /// <remarks/>
        public string DBHost
        {
            get
            {
                return this.dBHostField;
            }
            set
            {
                this.dBHostField = value;
            }
        }

        /// <remarks/>
        public string PrimaryDBHost
        {
            get
            {
                return this.primaryDBHostField;
            }
            set
            {
                this.primaryDBHostField = value;
            }
        }

        /// <remarks/>
        public string SecondaryDBHost
        {
            get
            {
                return this.secondaryDBHostField;
            }
            set
            {
                this.secondaryDBHostField = value;
            }
        }


  
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReplicationStatusSpecified
        {
            get
            {
                return this.replicationStatusFieldSpecified;
            }
            set
            {
                this.replicationStatusFieldSpecified = value;
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReplicationModeSpecified
        {
            get
            {
                return this.replicationModeFieldSpecified;
            }
            set
            {
                this.replicationModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string LastReplicationTime
        {
            get
            {
                return this.lastReplicationTimeField;
            }
            set
            {
                this.lastReplicationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Filename", IsNullable = false)]
        public string[] NotSyncedFiles
        {
            get
            {
                return this.notSyncedFilesField;
            }
            set
            {
                this.notSyncedFilesField = value;
            }
        }

  
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Attribute", IsNullable = false)]
        public attribute_type[] AdditionalAttributes
        {
            get
            {
                return this.additionalAttributesField;
            }
            set
            {
                this.additionalAttributesField = value;
            }
        }
    }

    public partial class attribute_type
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}