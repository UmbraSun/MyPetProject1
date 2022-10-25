using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// GPU connection
    /// </summary>
    public class GPUConnection : IEntity<int>
    {
        public int Id { get; set; }
        // GPU Connection interface
        public string ConnectionInterface { get; set; }
        // Connector form factor
        public string ConnectionFormFactor { get; set; }
        // Additional power connectors
        public string? AdditPowerConnectors { get; set; }
        // Recommended int PSU
        public int RecommendedPSU { get; set; }
        // Recommented unit PSU
        public UnitsOfMeasure UnitOfRecommendedPSU { get; set; }

        // GPU
        public virtual IList<GPU> GPU { get; set; }
    }
}
