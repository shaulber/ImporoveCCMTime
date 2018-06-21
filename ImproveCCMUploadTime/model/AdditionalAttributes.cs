using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace ImproveCCMUploadTime.Model
{
    [Serializable]
    [XmlRoot("AdditionalAttributes")]
    public class AdditionalAttributes
    {
        private Dictionary<string, string> attributes = new Dictionary<string, string>();

        [XmlElement("Attribute")]
        public XmlElement Attribute
        {
            get { return null; }
            set
            {

                string attributeKey = value["Name"].InnerText;
                string attributeValue = value["Value"].InnerText;
                attributes.Add(attributeKey, attributeValue);
            }
        }
    }
}