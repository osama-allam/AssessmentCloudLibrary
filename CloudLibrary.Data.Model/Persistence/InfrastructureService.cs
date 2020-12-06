using System.IO;
using System.Linq;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Core.Services.Responses;
using CloudLibrary.Data.Common.Contracts;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Persistence
{
    public class InfrastructureService : IInfrastructureService
    {
        
        private readonly IUnitOfWorkBase _unitOfWorkBase;
        public InfrastructureService(IUnitOfWorkBase unitOfWorkBase)
        {
            _unitOfWorkBase = unitOfWorkBase;
        }
        public CreateInfrastructureResponse CreateInfrastructure(string providerName, CreateInfrastructureRequest request)
        {
            var response = new CreateInfrastructureResponse();
            var infrastructure = new Infrastructure
            {
                Name = request.Name,
                Address = Path.Combine(providerName, request.Name),
                Location = request.Location
            };
            if (_unitOfWorkBase.CloudProviders.Find(providerName).Any())
            {
                var cloudProvider = _unitOfWorkBase.CloudProviders.Get(providerName);
                infrastructure.CloudProvider = cloudProvider;
                var infrastructureCreated = _unitOfWorkBase.Infrastructures.Add(infrastructure);
                response.Infrastructure = infrastructureCreated;
                response.OperationStatus = OperationStatus.Success;
            }
            else
            {
                response.OperationStatus = OperationStatus.Failed;
                response.Description = $"This cloud provider {providerName} doesn't exist";
            }
            return response;
        }
        public void DeleteInfrastructure(string providerName, string name)
        {
            var address = Path.Combine(providerName, name);
            var infrastructure = _unitOfWorkBase.Infrastructures.Get(address);
            if(infrastructure != null)
            {
                _unitOfWorkBase.Infrastructures.Remove(infrastructure);
            }
        }
    }
}