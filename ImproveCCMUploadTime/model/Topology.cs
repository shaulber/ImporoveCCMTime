using ImproveCCMUploadTime.model;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ImproveCCMUploadTime
{
    [Serializable]
    [XmlRoot("Get_components_response")]
    public class Topology
    {
        [XmlArray("Components"), XmlArrayItem("Component")]
        public List<Component> Components { get; set; }         
    }
}