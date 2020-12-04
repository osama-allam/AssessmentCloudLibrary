using CloudLibrary.Data.Common.Contracts;
using CloudLibrary.Data.Common.Core;
using CloudLibrary.Data.Common.Enum;

namespace CloudLibrary.Data.Entities.Core.Entities
{
    public class VirtualMachine : Resource<int>
    {
        public string VmId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ResourceType Type => ResourceType.VirtualMachine;
    }
}