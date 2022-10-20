using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class CPUCoreAndArchitecture : IEntity<int>
    {
        public int Id { get; set; }
        // Total Number Of Cores
        public int NumberOfCores { get; set; }
        // Maximum Number of processor thread
        public int MaxNumberOfThread { get; set; }
        // Number of Performance Cores
        public int NumberOfPerformanceCores { get; set; }
        // Number of Enenrgy Efficient Cores
        public int? NumberOfEfficientCores { get; set; }
        // Processor int L2 Cache Size
        public int? L2CacheSize { get; set; }
        //Processor unit L2 Cache Size
        public UnitsOfMeasure? UnitOfL2CacheSize { get; set; }
        // Processor int L3 Cache Size
        public int? L3CacheSize { get; set; }
        // Processor unit L3 Cache Size
        public UnitsOfMeasure? UnitOfL3CacheSize { get; set; }
        // Processor Technologe process
        public string ProcessTechnology { get; set; }
        // Name of Cores Architecture
        public string Core { get; set; }

    }
}
