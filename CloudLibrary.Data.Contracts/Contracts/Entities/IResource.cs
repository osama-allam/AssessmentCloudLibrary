using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Common.Contracts.Entities
{
    public interface IResource<T> : IAuditEntity<T> where T : class
    {
        string Name { get; set; }
        string Location { get; set; }
        ResourceType Type { get; }
        int CloudProviderId { get; set; }
        int HardwareProfileId { get; set; }
        int StorageProfileId { get; set; }
        int NetworkProfileId { get; set; }
        CloudProvider CloudProvider { get; set; }
        HardwareProfile HardwareProfile { get; set; }
        StorageProfile StorageProfile { get; set; }
        NetworkProfile NetworkProfile { get; set; }
    }
}