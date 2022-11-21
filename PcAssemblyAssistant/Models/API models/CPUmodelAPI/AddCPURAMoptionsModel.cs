using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.CPUmodelAPI
{
    public class AddCPURAMoptionsModel : IServiceResult
    {
        /// <summary>
        /// Processor Memory type
        /// </summary>
        public string MemoryType { get; set; }

        /// <summary>
        /// Maximum int Supported Memory
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaxSuppMemory cannot be.")]
        public int MaxSuppMemory { get; set; }

        /// <summary>
        /// Maximum unit Supported Memory
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfMaxSuppMemory { get; set; }

        /// <summary>
        /// Number of Memory Channel
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of NumberOfMemoryChanel cannot be.")]
        public int NumberOfMemoryChanel { get; set; }

        /// <summary>
        /// Maximum int RAM Frequency in Processor
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaximumRAMfrequency cannot be.")]
        public int MaximumRAMfrequency { get; set; }
        
        /// <summary>
        /// Maximum unit RAM Frequency in Processor
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfMaximumRAMfrequency { get; set; }
    }
}
