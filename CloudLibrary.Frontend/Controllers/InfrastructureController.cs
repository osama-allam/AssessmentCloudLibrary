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

namespace CloudLibrary.Frontend.Controllers
{
    [Route("api/Infrastructure/{providerName}")]
    [Produces("application/json", "application/xml")]
    public class InfrastructureController : Controller
    {
        
        private readonly IInfrastructureService _infrastructureService;

        public InfrastructureController(IInfrastructureService infrastructureService)
        {
            _infrastructureService = infrastructureService;
        }
        
        /// <summary>
        /// Create new Infrastructure
        /// </summary>
        /// <param name="request"></param>
        /// <response code="200">(Success) Returns a the created Infrastructure json</response>
        /// <response code="400">(BadRequest) In case of incorrect request parameters</response>
        /// <response code="406">(Not Acceptable) In case of using setting response other than JSON or XML</response>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreateInfrastructureResponse))]
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody]CreateInfrastructureRequest request)
        {
            if (ModelState.IsValid)
            {
                var providerName = RouteData.Values["providerName"].ToString();
                var response = _infrastructureService.CreateInfrastructure(providerName, request);
                if (response.OperationStatus == OperationStatus.Success)
                {
                    return Ok(response.Infrastructure);
                }
                return BadRequest(response);
            }
            return BadRequest();
        }
        /// <summary>
        /// Delete Infrastructure
        /// </summary>
        /// <param name="name"></param>
        /// <response code="200">(Success) Returns after successful deletion</response>
        /// <response code="400">(BadRequest) In case of incorrect request parameters</response>
        /// <response code="406">(Not Acceptable) In case of using setting response other than JSON or XML</response>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CloudProvider))]
        [Route("delete/{name}")]
        [HttpDelete]
        public IActionResult Delete(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest();
            }
            var providerName = RouteData.Values["providerName"].ToString();
            _infrastructureService.DeleteInfrastructure(providerName, name);
            return Ok();
        }
    }
}