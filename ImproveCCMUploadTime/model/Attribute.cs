using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ImproveCCMUploadTime.model
{
    [Serializable]
    public class Attribute : XmlElement
    {
        protected internal Attribute(string prefix, string localName, string namespaceURI, XmlDocument doc) : base(prefix, localName, namespaceURI, doc)
        {
            int a = 0;
        }
    }
}
