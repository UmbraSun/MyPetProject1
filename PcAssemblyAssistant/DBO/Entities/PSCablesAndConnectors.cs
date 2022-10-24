using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// Power Supply Cables and connectors
    /// </summary>
    public class PSCablesAndConnectors : IEntity<int>
    {
        public int Id { get; set; }
        // Main power connector
        public string MainPowerConnector { get; set; }
        // CPU Power Connectors
        public string? CPUPowerConnector { get; set; }
        // Video card power connectors
        public string? GPUPowerConnector { get; set; }
        // Number of 15-pin SATA connectors
        public string? SATA15PinConnector { get; set; }
        // Number of 4-pin Molex connectors
        public string? Molex4PinConnector { get; set; }
        // Connector 4 pin Floppy
        public string? Floppy4pinConnector { get; set; }

        // Power Supply
        public virtual IList<PS> PS { get; set; }
    }
}
