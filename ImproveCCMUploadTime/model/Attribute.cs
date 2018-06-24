using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ImproveCCMUploadTime.model
{
    public class Attribute
    {
        [XmlElement("Name")] public string Name { get; set; }

        [XmlElement("Value")] public string Value { get; set; }
    }
}
