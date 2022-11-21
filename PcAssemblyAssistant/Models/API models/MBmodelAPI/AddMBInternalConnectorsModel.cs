using Common.Custom_Attributes;
using Models.Interfaces;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBInternalConnectorsModel : IServiceResult
    {
        /// <summary>
        /// internal USB connectors on motherboard
        /// </summary>
        public string InternalUSBConnectors { get; set; }
        
        /// <summary>
        /// CPU cooler power connector
        /// </summary>
        public string? CPUCoolerPowerConnector { get; set; }

        /// <summary>
        /// count of 4-Pin PWM Fan Connectors
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of FanConnectorsPin4 cannot be.")]
        public int? FanConnectorsPin4 { get; set; }
        
        /// <summary>
        /// count of 3-Pin PWM Fan Connectors
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of FanConnectorsPin3 cannot be.")]
        public int? FanConnectorsPin3 { get; set; }
        
        /// <summary>
        /// count of 3-Pin LED Connector
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of LEDConnectorPin3 cannot be.")]
        public int? LEDConnectorPin3 { get; set; }
        
        /// <summary>
        /// count of 4-Pin LED Connector
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of LEDConnectorPin4 cannot be.")]
        public int? LEDConnectorPin4 { get; set; }
    }
}
