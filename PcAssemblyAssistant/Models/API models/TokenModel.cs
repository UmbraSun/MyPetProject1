using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.API_models
{
    /// <summary>
    /// Token model
    /// </summary>
    public class TokenModel
    {
        /// <summary>
        /// access token
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// refresh token
        /// </summary>
        public string RefreshToken { get; set; }
    }
}
