using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.CPUmodelAPI
{
    public class AddCPUCoreArchModel : IServiceResult
    {
        /// <summary>
        /// number of CPU Cores
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of cores cannot be.")]
        public int NumberOfCores { get; set; }

        /// <summary>
        /// Maximum number of CPU thread
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of thread cannot be.")]
        public int MaxNumberOfThread { get; set; }

        /// <summary>
        /// Number of Performance Cores
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of performance cores cannot be.")]
        public int NumberOfPerformanceCores { get; set; }

        /// <summary>
        /// Number of Enenrgy Efficient Cores
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of efficient cores cannot be.")]
        public int? NumberOfEfficientCores { get; set; }

        /// <summary>
        /// Processor int L2 Cache Size
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of L2 Cache size cannot be.")]
        public int? L2CacheSize { get; set; }

        /// <summary>
        /// Processor unit L2 Cache Size
        /// </summary>
        [NullOrEnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure? UnitOfL2CacheSize { get; set; }

        /// <summary>
        /// Processor int L3 Cache Size
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of L3 Cache size cannot be.")]
        public int? L3CacheSize { get; set; }

        /// <summary>
        /// Processor unit L3 Cache Size
        /// </summary>
        [NullOrEnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure? UnitOfL3CacheSize { get; set; }

        /// <summary>
        /// Processor Technologe process
        /// </summary>
        public string ProcessTechnology { get; set; }

        /// <summary>
        /// Name of Cores Architecture
        /// </summary>
        public string Core { get; set; }
    }
}
