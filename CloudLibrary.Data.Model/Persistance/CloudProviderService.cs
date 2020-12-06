using System.Linq;
using System.Threading.Tasks;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Data.Common.Contracts;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Core.Services.Persistance
{
    public class CloudProviderService : ICloudProviderService
    {
        
        private readonly IUnitOfWorkBase _unitOfWorkBase;
        public CloudProviderService(IUnitOfWorkBase unitOfWorkBase)
        {
            _unitOfWorkBase = unitOfWorkBase;
        }
        public CloudProvider CreateCloudProvider(CreateCloudProviderRequest request)
        {
            var cloudProvider = new CloudProvider
            {
                Name = request.Name,
                Location = request.Location
            };
            return _unitOfWorkBase.CloudProviders.Add(cloudProvider);
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