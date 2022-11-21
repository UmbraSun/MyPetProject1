using Common.Custom_Attributes;
using Models.Interfaces;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBBackPanelModel : IServiceResult
    {
        /// <summary>
        /// count and type USB back pannel
        /// </summary>
        public string CountAndTypeUSB { get; set; }
        
        /// <summary>
        /// video outputs
        /// </summary>
        public string? VideoOutputs { get; set; }

        /// <summary>
        /// count of Network ports
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of CountOfNetworkPorts cannot be.")]
        public int? CountOfNetworkPorts { get; set; }

        /// <summary>
        /// Count of analog audio jacks
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of CountOfAnalogAudioJacks cannot be.")]
        public int? CountOfAnalogAudioJacks { get; set; }
        
        /// <summary>
        /// Digital audio ports
        /// </summary>
        public string? DigitalAudioPorts { get; set; }
        
        /// <summary>
        /// Other connectors on the rear panel
        /// </summary>
        public string? Other { get; set; }
    }
}
