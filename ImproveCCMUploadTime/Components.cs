using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace ImproveCCMUploadTime
{
    [XmlRoot("Components")]
    public class Components 
    {
        [XmlElement("Compnent")]
        public List<Compnent> Steps { get; set; }
    }

    public class Compnent
    {
        [XmlElement("type")]
        public string Type { get; set; }
      
    }
}