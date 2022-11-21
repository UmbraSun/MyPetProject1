using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.RAMmodelAPI
{
    public class AddRAMTimingsModel : IServiceResult
    {
        /// <summary>
        /// CAS latency
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of CASLatency cannot be.")]
        public int CASLatency { get; set; }
        
        /// <summary>
        /// RAS to CAS Delay 
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of RAStoCASDelay cannot be.")]
        public int RAStoCASDelay { get; set; }
        
        /// <summary>
        /// Row Precharge Delay
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of RowPrechangeDelay cannot be.")]
        public int RowPrechangeDelay { get; set; }

    }
}
