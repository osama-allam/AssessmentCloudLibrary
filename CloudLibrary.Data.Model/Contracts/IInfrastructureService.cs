
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Core.Services.Responses;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Contracts
{
    public interface IInfrastructureService : IService
    {
        CreateInfrastructureResponse CreateInfrastructure(string providerName, CreateInfrastructureRequest request);
        void DeleteInfrastructure(string providerName, string name);
    }
}