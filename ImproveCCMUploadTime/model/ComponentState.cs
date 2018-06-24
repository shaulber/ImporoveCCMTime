using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ImproveCCMUploadTime.model
{
    public enum StateId
    {
        [XmlEnum("")]
        Unknown = -1,
        Up = 0,
        Unavailable = 2,
        Ignore = 3,
        Recycle = 4,


    }

    public class ComponentState
    {

        public StateId State { get; set; }

        public static StateId StateIdfromString(string state)
        {
            try
            {
                return (StateId)Enum.Parse(typeof(StateId), state);
            }
            catch (Exception e)
            {
                return StateId.Unknown;
            }
        }
    }
}