using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.RAMmodelAPI
{
    public class AddRAMPerformanceModel : IServiceResult
    {
        /// <summary>
        /// INT Clock Frequency
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of VolumeOfOneModule cannot be.")]
        public int ClockFrequency { get; set; }
        
        /// <summary>
        /// Unit Clock Frequency
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitClockFrequency { get; set; }
        
        /// <summary>
        /// Intel XMP profiles
        /// </summary>
        public string IntelXMPprofiles { get; set; }
    }
}
