using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DAL.Identity
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

        /// <summary>
        /// User Refresh token
        /// </summary>
        public string? RefreshToken { get; set; }
        
        /// <summary>
        /// Token expiry time
        /// </summary>
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}