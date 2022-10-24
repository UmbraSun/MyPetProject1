using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// Power Supply Electrical parameters
    /// </summary>
    public class PSElectricalParametrs : IEntity<int>
    {
        public int Id { get; set; }
        // Line current +12 V
        public string? LineCurrent12V { get; set; }
        // Line current +3.3 V
        public string? LineCurrent3V { get; set; }
        // Line current +5 V
        public string? LineCurrent5V { get; set; }
        // standby current
        public string? StandbyCurrent { get; set; }
        // Line current -12 V
        public string? LineCurrentMinus12V { get; set; }
        // Mains input voltage range
        public string? MainInputVoltageRange { get; set; }

        // Power Supply 
        public virtual IList<PS> PS { get; set; }
    }
}
