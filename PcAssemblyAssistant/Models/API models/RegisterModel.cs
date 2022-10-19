using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.API_models
{
    /// <summary>
    /// Registration model
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// User Full Name
        /// </summary>
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        /// <summary>
        /// User Email
        /// </summary>
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        /// <summary>
        /// User Password
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
