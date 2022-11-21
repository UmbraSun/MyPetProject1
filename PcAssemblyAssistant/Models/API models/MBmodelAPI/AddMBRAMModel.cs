using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBRAMModel : IServiceResult
    {
        /// <summary>
        /// Count of RAM slots
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of SlotsCount cannot be.")]
        public int SlotsCount { get; set; }
        
        /// <summary>
        /// motherboard RAM Form Factor
        /// </summary>
        public string RAMFormFactor { get; set; }
        
        /// <summary>
        /// moterboard Supported memory type
        /// </summary>
        public string RAMType { get; set; }
        
        /// <summary>
        /// count of RAM ! Channel ! 
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of CountOfRAMChannel cannot be.")]
        public int CountOfRAMChannel { get; set; }
        
        /// <summary>
        /// Maximum int memory on motherboard
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaximumMemory cannot be.")]
        public int MaximumMemory { get; set; }
        
        /// <summary>
        /// Maximum unit memory on motherboard
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfMaxMemory { get; set; }
        
        /// <summary>
        /// Maximum int of motherboard RAM supported frequency
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaxRAMFrequency cannot be.")]
        public int MaxRAMFrequency { get; set; }
        
        /// <summary>
        /// Maximum unit of motherboard RAM supported frequency
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitMaxRAMFrequency { get; set; }
    }
}
