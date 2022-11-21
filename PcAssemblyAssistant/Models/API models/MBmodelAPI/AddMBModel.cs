using Models.Interfaces;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBModel : IServiceResult
    {
        /// <summary>
        /// motherboard model
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Producer country Id
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// MB audio
        /// </summary>
        public AddMBAudioModel? AddMBAudioModel { get; set; }

        /// <summary>
        /// MB back panel
        /// </summary>
        public AddMBBackPanelModel? AddMBBackPanelModel { get; set; }

        /// <summary>
        /// MB cooling
        /// </summary>
        public AddMBCoolingModel? AddMBCollingModel { get; set; }
        
        /// <summary>
        /// MB CPU and Chipset
        /// </summary>
        public AddMbCPUandChipsetModel? AddMBCPUandChipsetModel { get; set; }

        /// <summary>
        /// MB expresion slots
        /// </summary>
        public AddMBExpensionSlotsModel? AddMBExpensionSlotsModel { get; set; }

        /// <summary>
        /// MB form factor
        /// </summary>
        public AddMBFormFactorModel? AddMBFormFactorModel { get; set; }
        
        /// <summary>
        /// MB internal connectors
        /// </summary>
        public AddMBInternalConnectorsModel? AddMBInternalConnectorsModel { get; set; }

        /// <summary>
        /// MB RAM
        /// </summary>
        public AddMBRAMModel? AddMBRAMModel { get; set; }

        /// <summary>
        /// MB storage device
        /// </summary>
        public AddMBStorageDeviceModel? AddMBStorageDeviceModel { get; set; }

        /// <summary>
        /// MB web
        /// </summary>
        public AddMBWebModel? AddMBWebModel { get; set; }
    }
}
