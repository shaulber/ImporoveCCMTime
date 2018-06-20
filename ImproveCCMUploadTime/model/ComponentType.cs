using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproveCCMUploadTime.model
{
    [Serializable]
    public enum ComponentTypeId
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
        Web_Server,
        Other
    }

    [Serializable]
    public class ComponentType
    {
        private ComponentTypeId _typeId;

        public ComponentType(ComponentTypeId typeId)
        {
            _typeId = typeId;
        }

        public static ComponentTypeId TypeIdFromValue(string value)
        {
            return (ComponentTypeId) Enum.Parse(typeof(ComponentTypeId), value);
        }
    }
}
