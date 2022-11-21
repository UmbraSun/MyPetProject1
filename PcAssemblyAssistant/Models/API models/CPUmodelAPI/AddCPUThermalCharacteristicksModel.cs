using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.CPUmodelAPI
{
    public class AddCPUThermalCharacteristicksModel : IServiceResult
    {
        /// <summary>
        /// Processor int heat disspation 
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of TDP cannot be.")]
        public int TDP { get; set; }
        
        /// <summary>
        /// Processor unit heat disspation
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfTDP { get; set; }

        /// <summary>
        /// maximum processor temprature
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaxCPUtemprature cannot be.")]
        public int MaxCPUtemprature { get; set; }
    }
}
