using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.CPUmodelAPI
{
    public class AddCPUGraphicsCoreModel : IServiceResult
    {
        /// <summary>
        /// Graphic Processor Model
        /// </summary>
        public string GPUModel { get; set; }

        /// <summary>
        /// Maximum int Frequency of Graphic Cores
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of GPUCoreFreqency cannot be.")]
        public int GPUCoreFreqency { get; set; }

        /// <summary>
        /// Maximum unit Frenquency of Graphic Cores
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfGPUCoreFreqency { get; set; }
        
        /// <summary>
        /// Number of Executive Blocks
        /// </summary>
        public int ExecutiveBlocks { get; set; }
    }
}
