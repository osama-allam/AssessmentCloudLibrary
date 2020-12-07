using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudLibrary.Core.Services.Contracts;
using CloudLibrary.Core.Services.Requests;
using CloudLibrary.Core.Services.Responses;
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
        /// <summary>
        /// Create new Cloud Provider
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">(Success) Returns a the created Cloud Provider json</response>
        /// <response code="400">(BadRequest) In case of incorrect request parameters</response>
        /// <response code="406">(Not Acceptable) In case of using setting response other than JSON or XML</response>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateCloudProviderResponse))]
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody]CreateCloudProviderRequest request)
        {
            if (ModelState.IsValid)
            {
                var createdCloudProviderResponse = _cloudProviderService.CreateCloudProvider(request);
                return Ok(createdCloudProviderResponse);
            }
            return BadRequest();
        }
        /// <summary>
        /// Delete Cloud Provider
        /// </summary>
        /// <param name="name"></param>
        /// <response code="200">(Success) Returns after successful deletion</response>
        /// <response code="400">(BadRequest) In case of incorrect request parameters</response>
        /// <response code="406">(Not Acceptable) In case of using setting response other than JSON or XML</response>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("delete/{name}")]
        [HttpDelete]
        public IActionResult Delete(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest();
            }
            _cloudProviderService.DeleteCloudProvider(name);
            return Ok();
        }
    }
}
