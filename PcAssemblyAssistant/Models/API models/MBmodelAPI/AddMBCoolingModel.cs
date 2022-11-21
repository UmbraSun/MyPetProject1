using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBCoolingModel : IServiceResult
    {
        /// <summary>
        /// Main power connector
        /// </summary>
        public string? MainPowerConnctor { get; set; }
        
        /// <summary>
        /// CPU power connector
        /// </summary>
        public string? CPUPowerConnector { get; set; }
        
        /// <summary>
        /// Count of power phases
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of PowerPhases cannot be.")]
        public int PowerPhases { get; set; }
        
        /// <summary>
        /// Passive Cooling
        /// </summary>
        public string? PassiveCooling { get; set; }
        
        /// <summary>
        /// Active Cooling
        /// </summary>
        public string? ActiveCooling { get; set; }
        
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
