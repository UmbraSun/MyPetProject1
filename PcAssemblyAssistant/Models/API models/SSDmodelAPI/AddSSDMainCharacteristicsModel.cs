using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.SSDmodelAPI
{
    public class AddSSDMainCharacteristicsModel : IServiceResult
    {
        /// <summary>
        /// INT SSD Storage capacity
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of StorageCapacity cannot be.")]
        public int StorageCapacity { get; set; }
        
        /// <summary>
        /// UNIT SSD storage capacity
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitOfStorageCapacity { get; set; }
        
        /// <summary>
        /// Form factor
        /// </summary>
        public string? FormFactor { get; set; }
        
        /// <summary>
        /// Physical interface or Connection connector
        /// </summary>
        public string PhysicalInterface { get; set; }
        
        /// <summary>
        /// Key M.2 connector
        /// </summary>
        public string? KeyM2Connector { get; set; }
        
        /// <summary>
        /// Do ssd have nvme?
        /// </summary>
        public bool NVMe { get; set; }
        
        /// <summary>
        /// SSD memory structure
        /// </summary>
        public string MemoryStructure { get; set; }
    }
}
