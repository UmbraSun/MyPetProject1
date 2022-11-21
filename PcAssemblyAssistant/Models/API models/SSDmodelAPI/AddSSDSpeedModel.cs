using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.SSDmodelAPI
{
    public class AddSSDSpeedModel : IServiceResult
    {
        /// <summary>
        /// Maximum Sequential Read Speed
        /// </summary>
        public string MaxSequentialReadSpeed { get; set; }
        
        /// <summary>
        /// Maximum sequebtial Write Soeed
        /// </summary>
        public string MaxSequentialWriteSpeed { get; set; }
        
        /// <summary>
        /// Random read speed of 4 KB files (IOPS - Number of I/O operations per second)
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of RandomReadSpeedOf4KBFiles cannot be.")]
        public int RandomReadSpeedOf4KBFiles { get; set; }
        
        /// <summary>
        /// Random write speed of 4 KB files (IOPS - Number of I/O operations per second)
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of RandomWriteSpeedOf4KBFiles cannot be.")]
        public int RandomWriteSpeedOf4KBFiles { get; set; }
        
        /// <summary>
        /// Energy INT consumption
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of EnergyConsumption cannot be.")]
        public int EnergyConsumption { get; set; }
        
        /// <summary>
        /// Energy UNIT consumption
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitEnergyConsumption { get; set; }
    }
}
