using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.CPUmodelAPI
{
    public class AddCPUGeneralParametrsModel : IServiceResult
    {
        /// <summary>
        /// Processor model
        /// </summary>
        public string Model { get; set; }
        
        /// <summary>
        /// Processor socket
        /// </summary>
        public string Socket { get; set; }
        
        /// <summary>
        /// Realise Date
        /// </summary>
        public DateTime? RealiseDate { get; set; }
        
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
