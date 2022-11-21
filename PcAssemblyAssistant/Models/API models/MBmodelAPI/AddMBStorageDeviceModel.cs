using Common.Custom_Attributes;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBStorageDeviceModel : IServiceResult
    {
        /// <summary>
        /// count of M2 SSD
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of CountOfM2 cannot be.")]
        public int? CountOfM2 { get; set; }
        
        /// <summary>
        /// M2 SSD connectors
        /// </summary>
        public string? M2Connectors { get; set; }
        
        /// <summary>
        /// count of port for ssd and hdd
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of CountOfPortsSATA cannot be.")]
        public int CountOfPortsSATA { get; set; }
        
        /// <summary>
        /// Is motherboard supported NVME
        /// </summary>
        public bool SupportedNVME { get; set; }
    }
}
