using System.Xml.Serialization;

namespace ImproveCCMUploadTime
{
    [XmlRoot("Get_components_response")]
    public class Topology
    {
        public string Components { get; set; }
    }
}