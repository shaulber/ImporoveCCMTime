using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace ImproveCCMUploadTime.Model
{
    public class AdditionalAttributes
    {
        [XmlElement("Attribute")]
        public XmlElement Attribute
        {
            get { return null; }
            set
            {

                //string attributeKey = value["Name"].InnerText;
                //string attributeValue = value["Value"].InnerText;
                //attributes.Add(attributeKey, attributeValue);
            }
        }
    }
}