using Models.Interfaces;

namespace Models.API_models.RAMmodelAPI
{
    public class AddRAMModel : IServiceResult
    {
        /// <summary>
        /// RAM model
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// RAM description
        /// </summary>
        public string? Description { get; set; }
        
        /// <summary>
        /// RAM producer code
        /// </summary>
        public string? ProducerCode { get; set; }

        /// <summary>
        /// producer country Id
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// RAM kit volume
        /// </summary>
        public AddRAMKitVolumeModel? AddRAMKitVolumeModel { get; set; }

        /// <summary>
        /// RAM performance
        /// </summary>
        public AddRAMPerformanceModel? AddRAMPerformanceModel { get; set; }

        /// <summary>
        /// RAM timings
        /// </summary>
        public AddRAMTimingsModel? AddRAMTimingsModel { get; set; }
    }
}
