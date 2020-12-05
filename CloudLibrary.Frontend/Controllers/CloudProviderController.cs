using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Data.Common.Persistence.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CloudLibrary.Frontend.Controllers
{
    [Route("api/CloudProvider")]
    [Produces("application/json", "application/xml")]
    [ApiController]
    public class CloudProviderController : ControllerBase
    {
        private readonly ICloudProviderService _cloudProviderService;

        public CloudProviderController(ICloudProviderService cloudProviderService)
        {
            _cloudProviderService = cloudProviderService;
        }

        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CloudProvider))]
        [HttpPost("Create")]
        public IActionResult Create(CreateCloudProviderRequest request)
        {
            var createdCloudProvider = _cloudProviderService.CreateCloudProvider(request);
            return Ok(createdCloudProvider);
        }
    }
}
