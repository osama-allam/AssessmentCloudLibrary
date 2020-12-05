using System.Threading.Tasks;
using CloudLibrary.Data.Common.Contracts.Repositories;

namespace CloudLibrary.Data.Common.Contracts
{
    public interface IUnitOfWorkBase
    {
        
        ICloudProviderRepository CloudProviderRepository { get; }
        IHardwareProfileRepository HardwareProfileRepository { get; }
        INetworkProfileRepository NetworkProfileRepository { get; }
        IOsProfileRepository OsProfileRepository { get; }
        IResourceRepository ResourceRepository { get; }
        IStorageProfileRepository StorageProfileRepository { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}