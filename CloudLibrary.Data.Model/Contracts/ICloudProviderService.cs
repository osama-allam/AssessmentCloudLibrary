using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Contracts
{
    public interface ICloudProviderService : IService
    {
        CloudProvider CreateCloudProvider(CreateCloudProviderRequest request);
        void DeleteCloudProvider(string name);
    }
}