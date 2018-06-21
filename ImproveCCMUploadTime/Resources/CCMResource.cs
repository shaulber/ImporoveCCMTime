namespace ImproveCCMUploadTime.model
{
    public abstract class CCMResource
    {
        public string Text { get; set; }
        public int ImageIndex { get; set; }
    }

    public class ComponentStateResource : CCMResource
    {

    }

}