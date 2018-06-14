using System.Xml;

namespace ImproveCCMUploadTime
{
    public class NodeItem
    {
        public string Key { get; private set; }

        public string Attr { get; private set; }

        public XmlNode XmlNode { get; private set; }

        public bool IsFiltered { get; set; }

        override public string ToString()
        {
            var keyXML = XmlNode.SelectSingleNode("ComponentKey");
            var itemKey = new CCMModelItemKey(keyXML);
            return itemKey.ToStringOneLine();
        }

        public NodeItem(XmlNode node)
        {
            var keyXML = node.SelectSingleNode("ComponentKey");
            if (keyXML == null)
            {
                return;
            }

            var attrXML = node.SelectSingleNode("Attributes");
            if (attrXML == null)
            {
                return;
            }

            var element = keyXML.SelectSingleNode("Type");
            if (element != null)
            {
                var type = element.InnerText.Trim();
                if (CCMModelItemKey.ShouldTypeIgnoreHostInKey(type))
                {
                    keyXML = keyXML.CloneNode(true); // to make sure host is still part of the original node. We only want to remove it from the key
                    var host = keyXML.SelectSingleNode("Host");
                    if (host != null)
                    {
                        keyXML.RemoveChild(host);
                    }
                }
            }

            Key = keyXML.InnerText;

            // CMS updates the LastUpdate field every tike it gets data from CTM, even if no chagne was done.
            // Since we compare old and new Attr to check if the component were changed, we ignore the LastUpdate field
            // so we only identify real updates.
            var lastUpdateField = attrXML.SelectSingleNode("LastUpdate");
            string lastUpdate = null;
            if (lastUpdateField != null)
            {
                lastUpdate = lastUpdateField.InnerText;
                lastUpdateField.InnerText = string.Empty;
            }

            Attr = attrXML.InnerText;

            if (lastUpdateField != null)
            {
                lastUpdateField.InnerText = lastUpdate;
            }

            XmlNode = node;

            IsFiltered = false; // by default
        }
    }
}