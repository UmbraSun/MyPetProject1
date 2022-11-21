using Models.Interfaces;

namespace Models.API_models.CPUmodelAPI
{
    public class AddCPUModel : IServiceResult
    {
        /// <summary>
        /// Processor Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Product Descriptions
        /// </summary>
        public string? Descriptions { get; set; }

        /// <summary>
        /// Country Id
        /// </summary>
        public int? CountryId { get; set; }

        public AddCPUCoreArchModel? CPUCoreArch { get; set; }
        public AddCPUFrequencyModel? CPUFreqModel { get; set; }
        public AddCPUGeneralParametrsModel? CPUGeneral { get; set; }
        public AddCPUGraphicsCoreModel? CPUGraphicsCore { get; set; }
        public AddCPURAMoptionsModel? CPURAMOption { get; set; }
        public AddCPUThermalCharacteristicksModel? CPUThermalChar { get; set; }
    }
}
