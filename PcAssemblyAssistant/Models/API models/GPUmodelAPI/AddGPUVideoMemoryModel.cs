using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.GPUmodelAPI
{
    public class AddGPUVideoMemoryModel : IServiceResult
    {
        /// <summary>
        /// GPU int video memory size
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of VideoMemorySize cannot be.")]
        public int VideoMemorySize { get; set; }

        /// <summary>
        /// GPU unit video memory size
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfVideoMemorySize { get; set; }

        /// <summary>
        /// GPU Memory Type
        /// </summary>
        public string MemoryType { get; set; }
        
        /// <summary>
        /// GPU memory bus widht
        /// </summary>
        public string MemoryBusWidht { get; set; }
        
        /// <summary>
        /// GPU maximum memory bandwith
        /// </summary>
        public string MaxMemoryBandwidth { get; set; }

        /// <summary>
        /// GPU int effictive memory frequency
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of VideoMemorySize cannot be.")]
        public int EffectiveMemoryFrequency { get; set; }

        /// <summary>
        /// GPU unit effictive memory frequency
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfEffectiveMemoryFrequency { get; set; }
    }
}
