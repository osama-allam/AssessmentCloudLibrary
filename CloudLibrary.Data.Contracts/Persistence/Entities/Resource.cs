using System;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public abstract class Resource<T> : AuditEntity<T> where T : struct
    {
        public virtual ResourceType Type => ResourceType.Undefined;
        public string Name { get; set; }
        public string Location { get; set; }
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