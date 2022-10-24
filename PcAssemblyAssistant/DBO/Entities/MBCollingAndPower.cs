using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class MBCollingAndPower : IEntity<int>
    {
        public int Id { get; set; }
        // Main power connector
        public string? MainPowerConnctor { get; set; }
        // CPU power connector
        public string? CPUPowerConnector { get; set; }
        // Count of power phases
        public int PowerPhases { get; set; }
        // Passive Cooling
        public string? PassiveCooling { get; set; }
        // Active Cooling
        public string? ActiveCooling { get; set; }

        public virtual IList<MB> MB { get; set; }
    }
}
