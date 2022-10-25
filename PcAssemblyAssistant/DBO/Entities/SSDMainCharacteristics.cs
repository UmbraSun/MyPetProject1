using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    // SSD Main characteristics
    public class SSDMainCharacteristics : IEntity<int>
    {
        public int Id { get; set; }
        // INT SSD Storage capacity
        public int StorageCapacity { get; set; }
        // UNIT SSD storage capacity
        public UnitsOfMeasure UnitOfStorageCapacity { get; set; }
        // Form factor
        public string? FormFactor { get; set; }
        // Physical interface or Connection connector
        public string PhysicalInterface { get; set; }
        // Key M.2 connector
        public string? KeyM2Connector { get; set; }
        // Do ssd have nvme?
        public bool NVMe { get; set; }
        // SSD memory structure
        public string MemoryStructure { get; set; }

        // SSD
        public virtual IList<SSD> SSD { get; set; }
    }
}
