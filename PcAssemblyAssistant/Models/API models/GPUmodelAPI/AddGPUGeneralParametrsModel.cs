using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.GPUmodelAPI
{
    public class AddGPUGeneralParametrsModel : IServiceResult
    {
        /// <summary>
        /// Name of graphic processor
        /// </summary>
        public string GraphicProcessor { get; set; }

        /// <summary>
        /// Name of GPU microarchitecture
        /// </summary>
        public string Microarchitecture { get; set; }

        /// <summary>
        /// process technology
        /// </summary>
        public string ProccessTechnology { get; set; }

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
