using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;


namespace ImproveCCMUploadTime
{
    [Serializable]
    public class Components 
    {
        [XmlArray("Component")]
        [XmlArrayItem("Component")]
        [XmlElement("Component")]
        public List<Component> Component { get; set; }
    }

    [Serializable]
    public class Component
    {
        [XmlElement("ComponentKey")]
        public ComponentKey ComponentKey { get; set; }

        [XmlElement("Attributes")]
        public Attributes Attributes { get; set; }

        [XmlArray("Sub_components"), XmlArrayItem("Component")]
        public List<Component> Sub_components { get; set; }
        

    }

    [Serializable]
    public class Sub_components
    {

    }

    [Serializable]
    public class Attributes
    {
    }

    [Serializable]
    public class ComponentKey
    { 
        public string Type { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
    }
}