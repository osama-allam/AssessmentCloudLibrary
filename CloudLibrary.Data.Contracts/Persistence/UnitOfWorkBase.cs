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
            Resources = new ResourceRepository(_root);
            Infrastructures = new InfrastructureRepository(_root);
        }
        public ICloudProviderRepository CloudProviders { get; }
        public IResourceRepository Resources { get; }
        public IInfrastructureRepository Infrastructures { get; }
    }
}