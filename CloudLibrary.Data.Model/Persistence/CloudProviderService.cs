using System.Linq;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Core.Services.Responses;
using CloudLibrary.Data.Common.Contracts;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Persistence
{
    public class CloudProviderService : ICloudProviderService
    {
        
        private readonly IUnitOfWorkBase _unitOfWorkBase;
        public CloudProviderService(IUnitOfWorkBase unitOfWorkBase)
        {
            _unitOfWorkBase = unitOfWorkBase;
        }
        public CreateCloudProviderResponse CreateCloudProvider(CreateCloudProviderRequest request)
        {
            
            var response = new CreateCloudProviderResponse{OperationStatus = OperationStatus.Success};
            if (_unitOfWorkBase.CloudProviders.Find(request.Name).Any())
            {
                response.CloudProvider = _unitOfWorkBase.CloudProviders.Get(request.Name);
                response.Description = $"Cloud Provider {request.Name} already exists";
            }
            var cloudProvider = new CloudProvider
            {
                Name = request.Name,
                Address = request.Name,
                Location = request.Location
            };
            response.CloudProvider = _unitOfWorkBase.CloudProviders.Add(cloudProvider);
            return response;
        }
        public void DeleteCloudProvider(string name)
        {
            var cloudProvider = _unitOfWorkBase.CloudProviders.Get(name);
            if(cloudProvider != null)
            {
                _unitOfWorkBase.CloudProviders.Remove(cloudProvider);
            }
        }
    }
}