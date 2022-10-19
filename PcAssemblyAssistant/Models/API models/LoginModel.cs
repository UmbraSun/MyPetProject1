using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.API_models
{
    /// <summary>
    /// model for login in acc
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// user email
        /// </summary>
        [Required(ErrorMessage = "User Email is required")]
        [EmailAddress(ErrorMessage = "Address non valid")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "2 - 10 symbols")]
        public string UserEmail { get; set; }

        /// <summary>
        /// user password
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
