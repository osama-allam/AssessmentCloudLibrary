using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Core.Services.Responses;
using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;
using CloudLibrary.Data.Core.Entities;

namespace CloudLibrary.Core.Services.Contracts
{
    public interface IResourceService : IService
    {
        CreateResourceResponse<IResource<string>> CreateResource(string providerName, string infrastructureName, ResourceType resourceType, IResource<string> resource);
        void DeleteResource(string providerName, string infrastructureName, string name);
    }
}