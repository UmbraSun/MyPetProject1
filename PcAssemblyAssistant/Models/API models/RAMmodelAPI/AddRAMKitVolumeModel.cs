using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.RAMmodelAPI
{
    public class AddRAMKitVolumeModel : IServiceResult
    {
        /// <summary>
        /// RAM memory type
        /// </summary>
        public string MemoryType { get; set; }
        
        /// <summary>
        /// RAM form factor
        /// </summary>
        public string FormFactor { get; set; }
        
        /// <summary>
        /// The total int amount of memory of the entire set
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of TotalAmount cannot be.")]
        public int TotalAmount { get; set; }
        
        /// <summary>
        /// The total unit amount of memory of the entire set
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitTotalAmount { get; set; }
        
        /// <summary>
        /// INT Volume of one memory module
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of VolumeOfOneModule cannot be.")]
        public int VolumeOfOneModule { get; set; }
        
        /// <summary>
        /// Unit Volume of one memory module
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitVolumeOfOneModule { get; set; }
        
        /// <summary>
        /// Number of modules included
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of NumOfModules cannot be.")]
        public int NumOfModules { get; set; }
   
        /// <summary>
        /// Register memory
        /// </summary>
        public bool RegisterMemory { get; set; }
        
        /// <summary>
        /// ECC memory
        /// </summary>
        public bool ECCMemory { get; set; }
        
        /// <summary>
        /// Rank
        /// </summary>
        public string? Rank { get; set; }
        
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
