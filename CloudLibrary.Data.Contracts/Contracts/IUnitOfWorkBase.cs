using System.Threading.Tasks;
using CloudLibrary.Data.Common.Contracts.Repositories;

namespace CloudLibrary.Data.Common.Contracts
{
    public interface IUnitOfWorkBase
    {
        
        ICloudProviderRepository CloudProviders { get; }
        IHardwareProfileRepository HardwareProfiles { get; }
        INetworkProfileRepository NetworkProfiles { get; }
        IOsProfileRepository OsProfiles { get; }
        IResourceRepository Resources { get; }
        IStorageProfileRepository StorageProfiles { get; }
        IInfrastructureRepository Infrastructures { get; }
    }
}