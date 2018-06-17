using System.Xml.Serialization;

namespace ImproveCCMUploadTime
{
    [XmlRoot("Components")]
    public class Topology
    {
        public string Components { get; set; }
    }
}