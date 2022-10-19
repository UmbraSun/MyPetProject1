using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.API_models
{
    /// <summary>
    /// Responce Model
    /// </summary>
    public class ResponseModel
    {
        /// <summary>
        /// responce status
        /// </summary>
        public string? Status { get; set; }
        
        /// <summary>
        /// responce message
        /// </summary>
        public string? Message { get; set; }
    }
}
