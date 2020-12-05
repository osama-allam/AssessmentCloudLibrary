using System;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public abstract class Resource<T> : DirectoryEntity<T> where T : class
    {
        public abstract ResourceType Type { get; }
        public int InfrastructureId { get; set; }
        public int HardwareProfileId { get; set; }
        public int StorageProfileId { get; set; }
        public int NetworkProfileId { get; set; }
        public Infrastructure Infrastructure { get; set; }
        public HardwareProfile HardwareProfile { get; set; }
        public StorageProfile StorageProfile { get; set; }
        public NetworkProfile NetworkProfile { get; set; }
    }
}