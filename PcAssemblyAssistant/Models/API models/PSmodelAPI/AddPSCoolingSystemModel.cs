using Models.Interfaces;

namespace Models.API_models.PSmodelAPI
{
    public class AddPSCoolingSystemModel : IServiceResult
    {
        /// <summary>
        /// Cooling system
        /// </summary>
        public string? CoolingSystem { get; set; }
        
        /// <summary>
        /// Fan dimensions
        /// </summary>
        public string? FanDiametrs { get; set; }
        
        /// <summary>
        /// Speed ​​control
        /// </summary>
        public string? SpeedControl { get; set; }
    }
}
