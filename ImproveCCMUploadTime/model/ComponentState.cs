namespace ImproveCCMUploadTime.model
{
    public enum State
    {
        Up,
        Down,
        Ignore,
        Recycle
    }

    public class ComponentState
    {
        public State State { get; set; }

    }
}