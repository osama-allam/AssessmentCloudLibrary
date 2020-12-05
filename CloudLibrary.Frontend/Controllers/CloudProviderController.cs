using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Data.Common.Persistence.Entities;
using CloudLibrary.Data.Core.Repositories.Contracts;
using CloudLibrary.Frontend.Models;
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
        
        //[ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        //[ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CloudProvider))]
        //[HttpPost]
        //public IActionResult Create(CloudProviderModel request)
        //{
        //    if (request == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (ModelState.IsValid)
        //    {

        //    }
        //}
    }
}
