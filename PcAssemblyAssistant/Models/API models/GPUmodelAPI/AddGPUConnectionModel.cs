using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.GPUmodelAPI
{
    public class AddGPUConnectionModel : IServiceResult
    {
        /// <summary>
        /// GPU Connection interface
        /// </summary>
        public string ConnectionInterface { get; set; }
        
        /// <summary>
        /// Connector form factor
        /// </summary>
        public string ConnectionFormFactor { get; set; }
        
        /// <summary>
        /// Additional power connectors
        /// </summary>
        public string? AdditPowerConnectors { get; set; }

        /// <summary>
        /// Recommended int PSU
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of RecommendedPSU cannot be.")]
        public int RecommendedPSU { get; set; }

        /// <summary>
        /// Recommented unit PSU
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfRecommendedPSU { get; set; }
    }
}
