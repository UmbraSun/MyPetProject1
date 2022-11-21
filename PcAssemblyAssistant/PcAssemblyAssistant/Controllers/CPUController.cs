using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.API_models.CPUmodelAPI;
using PcAssemblyAssistant.AppHelper;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace PcAssemblyAssistant.Controllers
{
    /// <summary>
    /// CPU controller
    /// </summary>
    [Route("api/CPU")]
    [ApiController]
    [ModelValidation]
    public class CPUController : ControllerBase
    {
        private readonly ICPUService _service;

        /// <summary>
        /// constructor with DI
        /// </summary>
        /// <param name="service">CPU service</param>
        public CPUController(ICPUService service)
        {
            _service = service;
        }

        /// <summary>
        /// Add new CPU 
        /// </summary>
        /// <param name="model">CPU model with characteristics</param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        [SwaggerResponse((int)HttpStatusCode.Unauthorized)]
        public async Task Add(AddCPUModel model)
        {
            await _service.BaseCreateModelAsync(model);
        }
    }
}
