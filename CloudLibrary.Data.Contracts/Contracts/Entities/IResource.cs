using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;

namespace CloudLibrary.Data.Common.Contracts.Entities
{
    public interface IResource<T> : IDirectoryEntity<T> where T : class
    {
        ResourceType Type { get; }
        int InfrastructureId { get; set; }
        int HardwareProfileId { get; set; }
        int StorageProfileId { get; set; }
        int NetworkProfileId { get; set; }
        Infrastructure Infrastructure { get; set; }
        HardwareProfile HardwareProfile { get; set; }
        StorageProfile StorageProfile { get; set; }
        NetworkProfile NetworkProfile { get; set; }
    }
}