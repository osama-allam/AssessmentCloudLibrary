using AutoMapper;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Core.Services.Responses;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Common.Persistence.Enum;
using CloudLibrary.Data.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudLibrary.Frontend.Controllers
{
    [Route("api/Resource/{providerName}/{infrastructure}")]
    [Produces("application/json", "application/xml")]
    public class ResourceController : Controller
    {
        private readonly IResourceService _resourceService;
        public ResourceController(IResourceService resourceService)
        {
            _resourceService = resourceService;
        }
        /// <summary>
        /// Create new virtual machine resource
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">(Success) Returns a the created Resource json</response>
        /// <response code="400">(BadRequest) In case of incorrect request parameters</response>
        /// <response code="406">(Not Acceptable) In case of using setting response other than JSON or XML</response>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateVmResourceRequest))]
        [Route("VirtualMachine/create")]
        [HttpPost]
        public IActionResult Create([FromBody] CreateVmResourceRequest request)
        {
            
            if (ModelState.IsValid)
            {
                var providerName = RouteData.Values["providerName"].ToString();
                var infrastructure = RouteData.Values["infrastructure"].ToString();
                var virtualMachine = new VirtualMachine
                {
                    Location = request.Location,
                    HardwareProfile = Mapper.Map<HardwareProfile>(request.HardwareProfile),
                    StorageProfile = Mapper.Map<StorageProfile>(request.StorageProfile),
                    NetworkProfile = Mapper.Map<NetworkProfile>(request.NetworkProfile),
                    AdditionalConfigurations = request.AdditionalConfigurations
                };
                var response = _resourceService.CreateResource(providerName, infrastructure,ResourceType.VirtualMachine, virtualMachine);
                if (response.OperationStatus == OperationStatus.Success)
                {
                    return Ok(response.Resource);
                }
                return BadRequest(response);
            }
            return BadRequest();
        }
    }
}