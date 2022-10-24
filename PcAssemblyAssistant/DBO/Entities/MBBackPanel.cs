using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// motherboard back panel
    /// </summary>
    public class MBBackPanel : IEntity<int>
    {
        public int Id { get; set; }
        // count and type USB back pannel
        public string CountAndTypeUSB { get; set; }
        // video outputs
        public string? VideoOutputs { get; set; }
        // count of Network ports
        public int? CountOfNetworkPorts { get; set; }
        // Count of analog audio jacks
        public int? CountOfAnalogAudioJacks { get; set; }
        // Digital audio ports
        public string? DigitalAudioPorts { get; set; }
        // Other connectors on the rear panel
        public string? Other { get; set; }
        
        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
