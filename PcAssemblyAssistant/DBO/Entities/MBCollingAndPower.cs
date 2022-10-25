using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
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
        // INT Power consumption
        public int Сonsumption { get; set; }
        // Unit Power consumption
        public UnitsOfMeasure UnitOfСonsumption { get; set; }

        public virtual IList<MB> MB { get; set; }
    }
}
