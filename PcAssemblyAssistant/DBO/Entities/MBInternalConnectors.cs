using DAL.Interfaces;

namespace DAL.Entities
{
    // motherboard internal connectors
    public class MBInternalConnectors : IEntity<int>
    {
        public int Id { get; set; }
        // internal USB connectors on motherboard
        public string InternalUSBConnectors { get; set; }
        // CPU cooler power connector
        public string? CPUCoolerPowerConnector { get; set; }
        // count of 4-Pin PWM Fan Connectors
        public int? FanConnectorsPin4 { get; set; }
        // count of 3-Pin PWM Fan Connectors
        public int? FanConnectorsPin3 { get; set; }
        // count of 3-Pin LED Connector
        public int? LEDConnectorPin3 { get; set; }
        // count of 4-Pin LED Connector
        public int? LEDConnectorPin4 { get; set; }

        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
