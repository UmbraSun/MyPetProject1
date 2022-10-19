using System.Data;
using System.Web.Http;

namespace PcAssemblyAssistant.Infrastructure
{
    /// <summary>
    /// authorize with roles attribute
    /// </summary>
    public class AuthorizeRolesAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// validation
        /// </summary>
        /// <param name="strs"></param>
        public AuthorizeRolesAttribute(params string[] strs)
        {
            Roles = string.Join(",", strs);
        }
    }
}
