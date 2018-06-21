using System;

namespace ImproveCCMUploadTime.model
{
    public enum StateId
    {
        Up,
        Unavailable,
        Ignore,
        Recycle,
        Other
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
                return StateId.Other;
            }
        }
    }
}