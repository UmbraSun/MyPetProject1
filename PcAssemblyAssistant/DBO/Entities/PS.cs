using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// Power Supply
    /// </summary>
    public class PS : IEntity<int>
    {
        public int Id { get; set; }
        // Power Supply model
        public string Name { get; set; }
        // Description
        public string? Description { get; set; }
        // INT Power supply capacity (nominal)
        public int Capacity { get; set; }
        // Unit Power supply capacity (nominal)
        public UnitsOfMeasure UnitOfCapacity { get; set; }

        // Producer country
        public Country? Country { get; set; }
        // Power supply cables and connectors
        public PSCablesAndConnectors? PSCablesAndConnectors { get; set; }
        // Power Supply Electrical parameters
        public PSElectricalParametrs? PSElectricalParametrs { get; set; }
        // Power Supply cooling system
        public PSCoolingSystem? PSCoolingSystem { get; set; }
        // Power supply certification
        public PSCertification? PSCertification { get; set; }
    }
}
