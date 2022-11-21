using Models.Interfaces;

namespace Models.API_models.GPUmodelAPI
{
    public class AddGPUCoolingSystemModel : IServiceResult
    {
        /// <summary>
        /// GPU cooling type
        /// </summary>
        public string? CoolingType { get; set; }
        
        /// <summary>
        /// Type and number of installed fans
        /// </summary>
        public string? TypeAndNumOfInstalledFans { get; set; }
        
        /// <summary>
        /// Liquid cooling radiator
        /// </summary>
        public string? LiquidCoolingRadiator { get; set; }
    }
}
