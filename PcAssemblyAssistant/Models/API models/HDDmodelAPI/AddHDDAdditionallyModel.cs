using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.HDDmodelAPI
{
    public class AddHDDAdditionallyModel : IServiceResult
    {
        /// <summary>
        /// Maximum INT power consumption
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaxPowerConsumption cannot be.")]
        public int MaxPowerConsumption { get; set; }

        /// <summary>
        /// Maximum Unit power consumption
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitMaxPowerConsumption { get; set; }

        /// <summary>
        /// INT Standby power consumption
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of StandbyPowerConsumpiton cannot be.")]
        public int StandbyPowerConsumpiton { get; set; }
        
        /// <summary>
        /// Unit Standby power consumption
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitStandbyPowerConsumpiton { get; set; }
        
        /// <summary>
        /// Minimum operating temprature °C
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MinOperatingTemp cannot be.")]
        public int MinOperatingTemp { get; set; }

        /// <summary>
        /// Maximum operating temrature °C
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of MaxOperatingTemp cannot be.")]
        public int MaxOperatingTemp { get; set; }
        
        /// <summary>
        /// INT Power consumption
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of Сonsumption cannot be.")]
        public int Сonsumption { get; set; }

        /// <summary>
        /// Unit Power consumption
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfСonsumption { get; set; }
    }
}
