using System.Collections.Generic;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Core.Entities
{
    public class VirtualMachine : Resource<string>
    {
        public VirtualMachine()
        {
            Type = ResourceType.VirtualMachine;
        }
        public Dictionary<string, string> AdditionalConfigurations { get; set; }
    }
}