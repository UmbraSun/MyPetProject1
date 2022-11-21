using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.CPUmodelAPI
{
    public class AddCPUFrequencyModel : IServiceResult
    {
        /// <summary>
        /// Base int Frequency
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of Frequency cannot be.")]
        public int Frequency { get; set; }

        /// <summary>
        /// Base unit Frenquecy
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitFrequecy { get; set; }

        /// <summary>
        /// Maximum int Frequency in Turbo mode
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of MaxFrequencyInTurbo cannot be.")]
        public int? MaxFrequencyInTurbo { get; set; }

        /// <summary>
        /// Maximum unit Frequency in Turbo mode
        /// </summary>
        [NullOrEnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure? UnitMaxFrequencyInTurbo { get; set; }

        /// <summary>
        /// Base int Frequency of energy efficient Cores 
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of FrequencyOfEfficientCores cannot be.")]
        public int? FrequencyOfEfficientCores { get; set; }

        /// <summary>
        /// Base unit Frequency of energy efficient Cores
        /// </summary>
        [NullOrEnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure? UnitFrequencyOfEfficientCores { get; set; }

        /// <summary>
        /// Maximum int Frequency in Turbo mode of energy efiicient Cores
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of MaxFrequencyTurboOfEfficientCores cannot be.")]
        public int? MaxFrequencyTurboOfEfficientCores { get; set; }
        
        /// <summary>
        /// Maximum unit Frequency in Turbo mode of energy efiicient Cores
        /// </summary>
        [NullOrEnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure? UnitMaxFrequencyTurboOfEfficientCores { get; set; }
        
        /// <summary>
        /// Free Multiplier
        /// </summary>
        public bool FreeMultiplier { get; set; }
    }
}
