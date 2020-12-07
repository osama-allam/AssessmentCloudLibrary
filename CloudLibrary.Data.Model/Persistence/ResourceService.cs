using System.IO;
using System.Linq;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Core.Services.Responses;
using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;
using CloudLibrary.Data.Core.Repositories.Contracts;

namespace CloudLibrary.Core.Services.Persistence
{
    public class ResourceService : IResourceService
    {
        private readonly IResourcesUnitOfWork _resourcesUnitOfWork;
        public ResourceService(IResourcesUnitOfWork resourcesUnitOfWork)
        {
            _resourcesUnitOfWork = resourcesUnitOfWork;
        }
        public CreateResourceResponse<IResource<string>> CreateResource(string providerName, string infrastructureName, ResourceType resourceType, IResource<string> resource)
        {
            var response = new CreateResourceResponse<IResource<string>>();
            resource.Address = Path.Combine(providerName, infrastructureName, resourceType.ToString());
            if (_resourcesUnitOfWork.CloudProviders.Find(providerName).Any())
            {
                var infraAddress = Path.Combine(providerName, infrastructureName);
                if (_resourcesUnitOfWork.Infrastructures.Find(infraAddress).Any())
                {
                    var infrastructure = _resourcesUnitOfWork.Infrastructures.Get(infraAddress);
                    resource.Infrastructure = infrastructure;
                    resource.Name = $"{infrastructureName}_{resourceType}";
                    var resourceCreated = _resourcesUnitOfWork.Resources.Add(resource);
                    response.Resource = resourceCreated;
                    response.OperationStatus = OperationStatus.Success;
                }
                else
                {
                    response.OperationStatus = OperationStatus.Failed;
                    response.Description = $"This Infrastructure {infrastructureName} doesn't exist";
                }

            }
            else
            {
                response.OperationStatus = OperationStatus.Failed;
                response.Description += $"This cloud provider {providerName} doesn't exist";
            }

            return response;
        }

        public void DeleteVmResource(string providerName, string infrastructureName, ResourceType resourceType)
        {
            var address = Path.Combine(providerName, infrastructureName, ResourceType.VirtualMachine.ToString());
            var virtualMachine = _resourcesUnitOfWork.VirtualMachines.Get(address);
            if(virtualMachine != null)
            {
                _resourcesUnitOfWork.Resources.Remove(virtualMachine);
            }
        }
        public void DeleteDataServerResource(string providerName, string infrastructureName, ResourceType resourceType)
        {
            var address = Path.Combine(providerName, infrastructureName, ResourceType.DataServer.ToString());
            var databaseServer = _resourcesUnitOfWork.DatabaseServers.Get(address);
            if(databaseServer != null)
            {
                _resourcesUnitOfWork.Resources.Remove(databaseServer);
            }
        }
    }
}