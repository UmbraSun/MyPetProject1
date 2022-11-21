using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.GPUmodelAPI
{
    public class AddGPUImageOutputModel : IServiceResult
    {
        /// <summary>
        /// video connectors
        /// </summary>
        public string VideoConnectors { get; set; }
        
        /// <summary>
        /// Display port version
        /// </summary>
        [Range(0, float.MaxValue, ErrorMessage = "Out of range. The number of DisplayPortVersion cannot be.")]
        public float DisplayPortVersion { get; set; }

        /// <summary>
        /// Number of monitors connected at the same time
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of NumOfMonitorConnect cannot be.")]
        public int NumOfMonitorConnect { get; set; }

        /// <summary>
        /// Maximum resolution
        /// </summary>
        public string MaxResolution { get; set; }
    }
}
