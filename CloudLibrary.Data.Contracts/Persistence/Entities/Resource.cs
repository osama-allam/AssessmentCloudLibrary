using System;
using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public class Resource<T> : DirectoryEntity<T>, IResource<T> where T : class
    {
        public virtual ResourceType Type => ResourceType.Undefined;
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