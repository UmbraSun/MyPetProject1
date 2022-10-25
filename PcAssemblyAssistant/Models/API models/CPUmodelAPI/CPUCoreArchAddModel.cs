using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.CPUmodelAPI
{
    internal class CPUCoreArchAddModel : IServiceResult
    {
        /// <summary>
        /// number of CPU Cores
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of cores cannot be.")]
        public int NumberOfCores { get; set; }

        /// <summary>
        /// Maximum number of CPU thread
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of thread")]
        public int MaxNumberOfThread { get; set; }
    }
}
