using Microsoft.AspNet.Identity.EntityFramework;

namespace DBO.Identity
{
    /// <summary>
    /// user DTO
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// User full name
        /// </summary>
        public string FullName { get; set; }
    }
}