using Common.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// RAM performance
    /// </summary>
    public class RAMPerformance : IEntity<int>
    {
        public int Id { get; set; }
        // INT Clock Frequency
        public int ClockFrequency { get; set; }
        // Unit Clock Frequency
        public UnitsOfMeasure UnitClockFrequency { get; set; }
        // Intel XMP profiles
        public string IntelXMPprofiles { get; set; }

        // RAM
        public virtual IList<RAM> RAM { get; set; }
    }
}
