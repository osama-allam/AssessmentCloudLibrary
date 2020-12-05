using System.Threading.Tasks;
using CloudLibrary.Data.Common.Contracts;
using CloudLibrary.Data.Common.Contracts.Repositories;

namespace CloudLibrary.Data.Common.Persistence
{
    public class UnitOfWorkBase : IUnitOfWorkBase
    {
        public ICloudProviderRepository CloudProviderRepository { get; }
        public IHardwareProfileRepository HardwareProfileRepository { get; }
        public INetworkProfileRepository NetworkProfileRepository { get; }
        public IOsProfileRepository OsProfileRepository { get; }
        public IResourceRepository ResourceRepository { get; }
        public IStorageProfileRepository StorageProfileRepository { get; }
        public IInfrastructureRepository InfrastructureRepository { get; }

        public int Complete()
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> CompleteAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}