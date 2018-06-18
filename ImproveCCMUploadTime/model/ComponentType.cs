using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproveCCMUploadTime.model
{
    [Serializable]
    public enum ComponentType
    {
        CTM_Agent,
        CTM_CM,
        CTM_Server,
        CMS,
        Database,
        EM,
        Gateway,
        GCS,
        GUI_Server,
        Naming_Server,
        Web_Server
    }
}
