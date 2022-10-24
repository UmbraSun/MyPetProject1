using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// Storage device
    /// </summary>
    public class HDDStorageDevice : IEntity<int>
    {
        public int Id { get; set; }
        // INT HDD volume
        public int VolumeHDD { get; set; }
        // Unit HDD volume
        public UnitsOfMeasure UnitOfVolumeHDD { get; set; }
        // INT Cache size
        public int CacheSize { get; set; }
        // Unit Cache size
        public UnitsOfMeasure UnitOfCacheSize { get; set; }
        // Spindle speed
        public string SpindleSpeed { get; set; }
        // Maximum data transfer rate
        public string MaxDataTransferRate { get; set; }
        // HDD interface
        public string IntarfaceHDD { get; set; }
        // Interface Bandwidth
        public string InterfaceBandwidth { get; set; }
        // Optimization for RAID arrays
        public bool OptForRAIDarrays { get; set; }

        // HDD
        public virtual IList<HDD> HDD { get; set; }
    }
}
