using Models.Interfaces;

namespace Models.API_models.GPUmodelAPI
{
    public class AddGPUModel : IServiceResult
    {
        /// <summary>
        /// Model
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Producer Code
        /// </summary>
        public string? ProducerCode { get; set; }

        /// <summary>
        /// Designed for mining
        /// </summary>
        public bool ForMining { get; set; }

        /// <summary>
        /// Producer country ID
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// GPU connection
        /// </summary>
        public AddGPUConnectionModel? AddGPUConnectionModel { get; set; }

        /// <summary>
        /// GPU cooling system
        /// </summary>
        public AddGPUCoolingSystemModel? AddGPUCoolingSystemModel { get; set; }

        /// <summary>
        /// GPU general parametrs
        /// </summary>
        public AddGPUGeneralParametrsModel? AddGPUGeneralParametrsModel { get; set; }

        /// <summary>
        /// GPU image output
        /// </summary>
        public AddGPUImageOutputModel? AddGPUImageOutputModel { get; set; }

        /// <summary>
        /// GPU video memory 
        /// </summary>
        public AddGPUVideoMemoryModel? AddGPUVideoMemoryModel { get; set; }

        /// <summary>
        /// GPU video processor
        /// </summary>
        public AddGPUVideoProcessorModel? AddGPUVideoProcessorModel { get; set; }
    }
}
