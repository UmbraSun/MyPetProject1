using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class CPURAMoptions : IEntity<int>
    {
        public int Id { get; set; }
        // Processor Memory type
        public string MemoryType { get; set; }
        // Maximum int Supported Memory
        public int MaxSuppMemory { get; set; }
        // Maximum unit Supported Memory
        public UnitsOfMeasure UnitOfMaxSuppMemory { get; set; }
        // Number of Memory Channel
        public int NumberOfMemoryChanel { get; set; }
        // Maximum int RAM Frequency in Processor
        public int MaximumRAMfrequency { get; set; }
        // Maximum unit RAM Frequency in Processor
        public UnitsOfMeasure UnitOfMaximumRAMfrequency { get; set; }
    }
}
