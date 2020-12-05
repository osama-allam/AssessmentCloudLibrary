using System.IO;
using System.Threading.Tasks;
using CloudLibrary.Data.Common.Contracts;
using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Repositories;

namespace CloudLibrary.Data.Common.Persistence
{
    public class UnitOfWorkBase : IUnitOfWorkBase
    {
        protected readonly string _root;
        public UnitOfWorkBase(string root)
        {
            _root = root;
            CloudProviders = new CloudProviderRepository(_root);
            HardwareProfiles = new HardwareProfileRepository(_root);
            NetworkProfiles = new NetworkProfileRepository(_root);
            OsProfiles = new OsProfileRepository(_root);
            Resources = new ResourceRepository(_root);
            StorageProfiles = new StorageProfileRepository(_root);
            Infrastructures = new InfrastructureRepository(_root);
        }
        public ICloudProviderRepository CloudProviders { get; }
        public IHardwareProfileRepository HardwareProfiles { get; }
        public INetworkProfileRepository NetworkProfiles { get; }
        public IOsProfileRepository OsProfiles { get; }
        public IResourceRepository Resources { get; }
        public IStorageProfileRepository StorageProfiles { get; }
        public IInfrastructureRepository Infrastructures { get; }
    }
}