namespace ImproveCCMUploadTime.model
{
    class ComponentResources
    {
        private static readonly ComponentResources instance = new ComponentResources();

        private ComponentResources()
        {
        }

        public static ComponentResources Instance => instance;

        public int getStateImageIndex(StateId stateId)
        {
            if (stateId == StateId.Up)
            {
                return 34;
            }
            else if (stateId == StateId.Unavailable)
            {
                return 32;
            }

            return -1;
        }
    }
}
