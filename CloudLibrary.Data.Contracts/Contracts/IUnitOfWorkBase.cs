using System.Threading.Tasks;
using CloudLibrary.Data.Common.Contracts.Repositories;

namespace CloudLibrary.Data.Common.Contracts
{
    public interface IUnitOfWorkBase
    {
        
        ICloudProviderRepository CloudProviders { get; }
        IResourceRepository Resources { get; }
        IInfrastructureRepository Infrastructures { get; }
    }
}