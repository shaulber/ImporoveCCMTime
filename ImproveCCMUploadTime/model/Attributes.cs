using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using ImproveCCMUploadTime.model;
using Attribute = ImproveCCMUploadTime.model.Attribute;

namespace ImproveCCMUploadTime.Model
{
    public class Attributes
    {
        [XmlElement("CurrentState")] public StateId CurrentState { get; set; }

        [XmlElement("Status")] public int Status { get; set; }

        [XmlElement("StatusMessage")] public string StatusMessage { get; set; }

        [XmlElement("OSType")] public string OSType { get; set; }

        [XmlElement("Version")] public string Version { get; set; }

        [XmlElement("LastUpdate")] public string LastUpdate { get; set; }

        [XmlArray("AdditionalAttributes"), XmlArrayItem("Attribute")] public List<Attribute> AdditionalAttributes { get; set; }
        //[XmlElement("AdditionalAttributes")] public AdditionalAttributes AdditionalAttributes { get; set; }
    }

}
