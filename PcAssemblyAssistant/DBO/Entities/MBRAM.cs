using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// motherboard RAM
    /// </summary>
    public class MBRAM : IEntity<int>
    {
        public int Id { get; set; }
        // Count of RAM slots
        public int SlotsCount { get; set; }
        // motherboard RAM Form Factor
        public string RAMFormFactor { get; set; }
        // moterboard Supported memory type
        public string RAMType { get; set; }
        // count of RAM ! Channel ! 
        public int CountOfRAMChannel { get; set; }
        // Maximum int memory on motherboard
        public int MaximumMemory { get; set; }
        // Maximum unit memory on motherboard
        public UnitsOfMeasure UnitOfMaxMemory { get; set; }
        // Maximum int of motherboard RAM supported frequency
        public int MaxRAMFrequency { get; set; }
        // Maximum unit of motherboard RAM supported frequency
        public UnitsOfMeasure UnitMaxRAMFrequency { get; set; }

        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
