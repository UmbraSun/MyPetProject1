using Models.Interfaces;

namespace Models.API_models.PSmodelAPI
{
    public class AddPSCablesModel : IServiceResult
    {
        /// <summary>
        /// Main power connector
        /// </summary>
        public string MainPowerConnector { get; set; }
        
        /// <summary>
        /// CPU Power Connectors
        /// </summary>
        public string? CPUPowerConnector { get; set; }
        
        /// <summary>
        /// Video card power connectors
        /// </summary>
        public string? GPUPowerConnector { get; set; }
        
        /// <summary>
        /// Number of 15-pin SATA connectors
        /// </summary>
        public string? SATA15PinConnector { get; set; }
        
        /// <summary>
        /// Number of 4-pin Molex connectors
        /// </summary>
        public string? Molex4PinConnector { get; set; }
        
        /// <summary>
        /// Connector 4 pin Floppy
        /// </summary>
        public string? Floppy4pinConnector { get; set; }
    }
}
