using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ImproveCCMUploadTime
{
    [Serializable]
    [XmlRoot("Get_components_response")]
    public class Topology
    {

        //  [XmlElement("Components")]
        // public Components Components { get; set; }
        [XmlArray("Components"), XmlArrayItem("Component")]
        public List<Component> Components { get; set; }
    }
}