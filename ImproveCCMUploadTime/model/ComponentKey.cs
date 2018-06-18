using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImproveCCMUploadTime.model
{
    [Serializable]
    public class ComponentKey
    {
        private ComponentTypeId _componentTypeId;
        private ComponentType _componentType;

        public ComponentTypeId Type
        {
            get => _componentTypeId;
            set
            {
                _componentTypeId = value;
                _componentType = new ComponentType(_componentTypeId);
            }
        }

        public string Name { get; set; }
        public string Host { get; set; }
    }
}