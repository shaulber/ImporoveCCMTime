using System;
using System.Xml;

namespace ImproveCCMUploadTime
{
    public class CCMModelItemKey : IComparable, IEquatable<CCMModelItemKey>
    {

        private readonly string _innerText = "";
        public string InnerText { get { return _innerText; } }


        private readonly string _type = "";
        public string Type { get { return _type; } }


        private readonly string _name = "";
        public string Name { get { return _name; } }


        private readonly string _host = "";
        public string Host { get { return _host; } }


        private readonly string _nodeId = "";
        public string NodeId { get { return _nodeId; } }


        private readonly string _applType = "";
        public string ApplType { get { return _applType; } }


        private readonly string _applVer = "";
        public string ApplVer { get { return _applVer; } }


        private readonly string _cmVer = "";
        public string CMVer { get { return _cmVer; } }


        private readonly string _extension = "";
        public string Extension { get { return _extension; } }

        public CCMModelItemKey(XmlNode keyNode = null)
        {
            if (keyNode == null) return;

            try
            {
                XmlNode element;

                _innerText = keyNode.InnerText;

                if ((element = keyNode.SelectSingleNode("Type")) != null)
                {
                    _type = element.InnerText.Trim();
                    if (_type == "CM")
                    {
                        _type = "CTM_CM";
                    }
                }
                if ((element = keyNode.SelectSingleNode("Name")) != null)
                {
                    _name = element.InnerText.Trim();
                }
                if ((element = keyNode.SelectSingleNode("Host")) != null)
                {
                    _host = element.InnerText.Trim();
                }
                if ((element = keyNode.SelectSingleNode("NodeID")) != null)
                {
                    _nodeId = element.InnerText.Trim();
                }
                if ((element = keyNode.SelectSingleNode("ApplType")) != null)
                {
                    _applType = element.InnerText.Trim();
                }
                if ((element = keyNode.SelectSingleNode("ApplVer")) != null)
                {
                    _applVer = element.InnerText.Trim();
                }
                if ((element = keyNode.SelectSingleNode("CMVer")) != null)
                {
                    _cmVer = element.InnerText.Trim();
                }
                if ((element = keyNode.SelectSingleNode("Extension")) != null)
                {
                    _extension = element.InnerText.Trim();
                }
            }
            catch (Exception ex)
            {
                var sMsg = "Failed to set component key from XML node: " + ex.Message;
            }
        }

        #region IComparable Members

        /// <summary>
        /// Compare this Model Item key to another, type/host/name order.
        /// </summary>
        /// <param name="obj">Other Model Item Key</param>
        /// <returns>less then 0 - this item is less then obj, 0 - same etc.</returns>
        public int CompareTo(object obj)
        {
            var other = (CCMModelItemKey)obj;

            var myStr = ToString();
            var otherStr = other.ToString();
            return String.Compare(myStr, otherStr, StringComparison.Ordinal);
        }

        public override String ToString()
        {
            try
            {
                if (ShouldTypeIgnoreHostInKey(Type)) // in case EM/CTM remove host , for fallback/failover (name is unique)
                {
                    return "CCMModelItemKey Data:"
                       + "\nType:       " + Type
                       + "\nName:       " + Name
                       + "\nNodeId:     " + NodeId
                       + "\nAppl. Type: " + ApplType
                       + "\nAppl. Ver.: " + ApplVer
                       + "\nCM Ver.:    " + CMVer
                       + "\nExtension:  " + Extension;
                }
                return "CCMModelItemKey Data:"
                       + "\nType:       " + Type
                       + "\nName:       " + Name
                       + "\nHost:       " + Host
                       + "\nNodeId:     " + NodeId
                       + "\nAppl. Type: " + ApplType
                       + "\nAppl. Ver.: " + ApplVer
                       + "\nCM Ver.:    " + CMVer
                       + "\nExtension:  " + Extension;
            }
            catch (Exception e)
            {
                var sMsg = String.Format("Failed to print CCMModelItemKey contents: {0}", e.Message);
            }

            return "CCMModelItemKey";
        }
        #endregion



        public static bool ShouldTypeIgnoreHostInKey(string type)
        {
            // Since CTM server and EM might fallback, we ignore their host in their key
            return type == "CTM_Server" || type == "EM";
        }

        public bool Equals(CCMModelItemKey other)
        {
            return other != null &&
                   Type == other.Type &&
                   Name == other.Name &&
                   (ShouldTypeIgnoreHostInKey(Type) || Host == other.Host) &&
                   NodeId == other.NodeId &&
                   ApplType == other.ApplType &&
                   ApplVer == other.ApplVer &&
                   CMVer == other.CMVer &&
                   Extension == other.Extension;
        }

        // http://stackoverflow.com/questions/17224940/what-is-the-default-equality-comparer-for-a-set-type
        // http://stackoverflow.com/questions/371328/why-is-it-important-to-override-gethashcode-when-equals-method-is-overridden
        public override int GetHashCode()
        {
            // http://stackoverflow.com/a/263416/46635
            unchecked // Overflow is fine, just wrap
            {
                var hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + Type.GetHashCode();
                hash = hash * 23 + Name.GetHashCode();
                if (!ShouldTypeIgnoreHostInKey(Type)) hash = hash * 23 + Host.GetHashCode();
                hash = hash * 23 + NodeId.GetHashCode();
                hash = hash * 23 + ApplType.GetHashCode();
                hash = hash * 23 + ApplVer.GetHashCode();
                hash = hash * 23 + CMVer.GetHashCode();
                hash = hash * 23 + Extension.GetHashCode();
                return hash;
            }
        }

        public String ToStringOneLine()
        {
            var str = String.Empty;
            try
            {
                str = String.Format("Type='{0}', Name='{1}', Host='{2}', NodeId='{3}'", Type, Name, Host, NodeId);
                if (ApplType != String.Empty)
                    str += ", Appl.Type='" + ApplType + "'";
                if (ApplVer != String.Empty)
                    str += ", Appl.Ver='" + ApplVer + "'";
                if (CMVer != String.Empty)
                    str += ", CM Ver='" + CMVer + "'";
                if (Extension != String.Empty)
                    str += ", Extension='" + Extension + "'";
            }
            catch (Exception e)
            {
                var sMsg = String.Format("Failed to print CCMModelItemKey contents: {0}", e.Message);
            }
            return str;
        }

        public componentKey_type ToCCMApiComponentKey()
        {
            return new componentKey_type
            {
                Type = Type,
                Name = Name,
                Host = Host,
                NodeID = NodeId,
                ApplType = ApplType,
                ApplVer = ApplVer,
                CMVer = CMVer,
                Extension = Extension
            };
        }

        public static CCMModelItemKey FromCCMApiComponentKey(componentKey_type _this)
        {
            return new CCMModelItemKey(_this.Type, _this.Name, _this.Host, _this.NodeID, _this.ApplType, _this.ApplVer, _this.CMVer, _this.Extension);

        }

        public CCMModelItemKey(string type, string name, string host, string nodeID, string applType, string applVer, string cMVer, string extension)
        {
            this._type = type;
            this._name = name;
            this._host = host;
            this._nodeId = nodeID;
            this._applType = applType;
            this._applVer = applVer;
            this._cmVer = cMVer;
            this._extension = extension;
        }


    }

    public partial class componentKey_type
    {

        private string typeField;

        private string nameField;

        private string hostField;

        private string nodeIDField;

        private string applTypeField;

        private string applVerField;

        private string cMVerField;

        private string extensionField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

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
        public string Host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }

        /// <remarks/>
        public string NodeID
        {
            get
            {
                return this.nodeIDField;
            }
            set
            {
                this.nodeIDField = value;
            }
        }

        /// <remarks/>
        public string ApplType
        {
            get
            {
                return this.applTypeField;
            }
            set
            {
                this.applTypeField = value;
            }
        }

        /// <remarks/>
        public string ApplVer
        {
            get
            {
                return this.applVerField;
            }
            set
            {
                this.applVerField = value;
            }
        }

        /// <remarks/>
        public string CMVer
        {
            get
            {
                return this.cMVerField;
            }
            set
            {
                this.cMVerField = value;
            }
        }

        /// <remarks/>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }
}