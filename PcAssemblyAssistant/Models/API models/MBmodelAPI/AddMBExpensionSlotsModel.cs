using Common.Custom_Attributes;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBExpensionSlotsModel : IServiceResult
    {
        /// <summary>
        /// PCI Express version
        /// </summary>
        public string PCIExpressVersion { get; set; }
        
        /// <summary>
        /// Count of PCI Express x16 slots
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of Сonsumption cannot be.")]
        public int CountOfPCIExX16Slots { get; set; }
        
        /// <summary>
        /// supported PCI or CrossFire and version
        /// </summary>
        public string? SupportedPCIorCrossfire { get; set; }

        /// <summary>
        /// Count of slots PCI or Crossfire
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of Сonsumption cannot be.")]
        public int? CountOfPCIorCrossfire { get; set; }
        
        /// <summary>
        /// Count of PCI-E x1 slots
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of Сonsumption cannot be.")]
        public int? CountOfPCIExX1Slots { get; set; }
    }
}
