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
            _unitOfWorkBase.CloudProviders.Add(cloudProvider);
            return cloudProvider;
        }
        public void DeleteCloudProvider(string name)
        {
            if(_unitOfWorkBase.CloudProviders.Find(cp => cp.Name == name).Any())
            {
                var cloudProvider = _unitOfWorkBase.CloudProviders.Get(name);
                _unitOfWorkBase.CloudProviders.Remove(cloudProvider);
            }
        }
    }
}