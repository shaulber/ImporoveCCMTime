using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ImproveCCMUploadTime.model;

namespace ImproveCCMUploadTime.Model
{
    [Serializable]
    [XmlRoot("Attributes")]
    public partial class Attributes
    {
        public const string CurrentState = "CurrentState";
        public const string DesiredState = "DesiredState";
        public const string OSType = "OSType";
        public const string Version = "Version";
        public const string DBHost = "DBHost";
        public const string HasHighAvailability = "HasHighAvailability";
        public const string SecondaryDBHost = "SecondaryDBHost";
        public const string PrimaryHost = "PrimaryHost";
        public const string PrimaryDBHost = "PrimaryDBHost";
        public const string SecondaryHost = "SecondaryHost";
        public const string StatusMessage = "StatusMessage";
        public const string LastUpdate = "LastUpdate";

        private Dictionary<string, string> attributes = new Dictionary<string, string>();
        private Dictionary<string, string> additionalAttributes = new Dictionary<string, string>();

        [XmlElement("AdditionalAttributes")]
        public XmlElement Additionals
        {
            get { return null; }
            set
            {
                try
                {
                    string attributeKey = value["Name"].InnerText;
                    string attributeValue = value["Value"].InnerText;

                    additionalAttributes.Add(attributeKey, attributeValue);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        
        [XmlAnyElement]
        public XmlElement Attribute
        {
            get { return null; }
            set
            {
                attributes.Add(value.Name, value.InnerText);
            }
        
        }

        public string GetAttribueValue(string attributeName)
        {
            return attributes[attributeName];
        }
    }
}
