using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ImproveCCMUploadTime.Model;

namespace ImproveCCMUploadTime.model
{
    [Serializable]
    public class Component
    {
        [XmlElement("ComponentKey")]
        public ComponentKey ComponentKey { get; set; }

        [XmlElement("Attributes")]
        public Attributes Attributes { get; set; }

        [XmlArray("Sub_components"), XmlArrayItem("Component")]
        public List<Component> Sub_components { get; set; }

        public override string ToString()
        {
            return ComponentKey.Type + ": " + ComponentKey.Host;
        }

        public StateId getCurrentState()
        {
            string currentState = Attributes.GetAttribueValue(Attributes.CurrentState);
            return ComponentState.StateIdfromString(currentState);
        }
    }
}
