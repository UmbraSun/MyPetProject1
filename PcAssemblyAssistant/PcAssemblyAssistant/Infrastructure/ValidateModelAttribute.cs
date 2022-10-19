using System.Net;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PcAssemblyAssistant.Infrastructure
{
    /// <summary>
    /// validation model attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// action filter
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ModelState.IsValid == false)
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
        }
    }
}
