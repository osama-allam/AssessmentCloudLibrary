using System.Collections.Generic;
using CloudLibrary.Core.Services.Model;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;
using Newtonsoft.Json;

namespace CloudLibrary.Core.Services.Requests
{
    public abstract class CreateResourceRequest
    {
        public string Location { get; set; }
        public HardwareProfileModel HardwareProfile { get; set; }
        public StorageProfileModel StorageProfile { get; set; }
        public NetworkProfileModel NetworkProfile { get; set; }
        public Dictionary<string, string> AdditionalConfigurations { get; set; }
    }
}