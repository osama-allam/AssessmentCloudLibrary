﻿using System.Collections.Generic;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Core.Entities
{
    public class VirtualMachine : Resource<string>
    {
        public override ResourceType Type => ResourceType.VirtualMachine;
        public string VmId { get; set; }
        public Dictionary<string, string> AdditionalConfigurations { get; set; }
    }
}