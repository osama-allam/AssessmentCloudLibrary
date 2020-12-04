using CloudLibrary.Data.Common.Core;
using CloudLibrary.Data.Common.Enum;

namespace CloudLibrary.Data.Common.Contracts
{
    public interface IResource : IAuditEntity
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