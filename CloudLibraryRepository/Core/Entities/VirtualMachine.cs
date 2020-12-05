using System.Collections.Generic;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Core.Entities.Core.Entities
{
    public class VirtualMachine : Resource<int>
    {
        public string VmId { get; set; }
        public ResourceType Type => ResourceType.VirtualMachine;
        public Dictionary<string, string> AdditionalConfigurations { get; set; }
    }
}