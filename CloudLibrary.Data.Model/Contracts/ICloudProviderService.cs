using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Core.Services.Responses;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Contracts
{
    public interface ICloudProviderService : IService
    {
        CreateCloudProviderResponse CreateCloudProvider(CreateCloudProviderRequest request);
        void DeleteCloudProvider(string name);
    }
}