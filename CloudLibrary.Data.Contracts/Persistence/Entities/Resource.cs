using System;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Common.Persistence.Entities
{
    public abstract class Resource<T> : AuditEntity<T> where T : struct
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ResourceType Type { get; }
        public int CloudProviderId { get; set; }
        public int HardwareProfileId { get; set; }
        public int StorageProfileId { get; set; }
        public int NetworkProfileId { get; set; }
        public CloudProvider CloudProvider { get; set; }
        public HardwareProfile HardwareProfile { get; set; }
        public StorageProfile StorageProfile { get; set; }
        public NetworkProfile NetworkProfile { get; set; }
    }
}