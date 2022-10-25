using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// RAM volume and composition of the kit
    /// </summary>
    public class RAMKitVolumeAndComposition : IEntity<int>
    {
        public int Id { get; set; }
        // RAM memory type
        public string MemoryType { get; set; }
        // RAM form factor
        public string FormFactor { get; set; }
        // The total int amount of memory of the entire set
        public int TotalAmount { get; set; }
        // The total unit amount of memory of the entire set
        public UnitsOfMeasure UnitTotalAmount { get; set; }
        // INT Volume of one memory module
        public int VolumeOfOneModule { get; set; }
        // Unit Volume of one memory module
        public UnitsOfMeasure UnitVolumeOfOneModule { get; set; }
        // Number of modules included
        public int NumOfModules { get; set; }
        // Register memory
        public bool RegisterMemory { get; set; }
        // ECC memory
        public bool ECCMemory { get; set; }
        // Rank
        public string? Rank { get; set; }
        // INT Power consumption
        public int Сonsumption { get; set; }
        // Unit Power consumption
        public UnitsOfMeasure UnitOfСonsumption { get; set; }

        // RAM
        public virtual IList<RAM> RAM { get; set; }
    }
}
