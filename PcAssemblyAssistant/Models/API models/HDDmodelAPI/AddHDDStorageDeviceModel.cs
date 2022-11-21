using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.HDDmodelAPI
{
    public class AddHDDStorageDeviceModel : IServiceResult
    {
        /// <summary>
        /// INT HDD volume
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of VolumeHDD cannot be.")]
        public int VolumeHDD { get; set; }
        
        /// <summary>
        /// Unit HDD volume
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfVolumeHDD { get; set; }
        
        /// <summary>
        /// INT Cache size
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of CacheSize cannot be.")]
        public int CacheSize { get; set; }
        
        /// <summary>
        /// Unit Cache size
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfCacheSize { get; set; }
        
        /// <summary>
        /// Spindle speed
        /// </summary>
        public string SpindleSpeed { get; set; }
        
        /// <summary>
        /// Maximum data transfer rate
        /// </summary>
        public string MaxDataTransferRate { get; set; }
        
        /// <summary>
        /// HDD interface
        /// </summary>
        public string IntarfaceHDD { get; set; }
        
        /// <summary>
        /// Interface Bandwidth
        /// </summary>
        public string InterfaceBandwidth { get; set; }
        
        /// <summary>
        /// Optimization for RAID arrays
        /// </summary>
        public bool OptForRAIDarrays { get; set; }
    }
}
