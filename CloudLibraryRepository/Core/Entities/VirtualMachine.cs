using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Core.Entities.Core.Entities
{
    public class VirtualMachine : Resource<int>
    {
        public string VmId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ResourceType Type => ResourceType.VirtualMachine;
    }
}