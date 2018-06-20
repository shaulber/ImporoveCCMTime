using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImproveCCMUploadTime.model
{
    [Serializable]
    public class Component
    {
        [XmlElement("ComponentKey")]
        public ComponentKey ComponentKey { get; set; }

        [XmlArray("Attributes"), XmlArrayItem("Attribute")]
        public List<Attribute> Attributes { get; set; }

        [XmlArray("Sub_components"), XmlArrayItem("Component")]
        public List<Component> Sub_components { get; set; }

        public override string ToString()
        {
            return ComponentKey.Type + ": " + ComponentKey.Host;
        }
    }
}
