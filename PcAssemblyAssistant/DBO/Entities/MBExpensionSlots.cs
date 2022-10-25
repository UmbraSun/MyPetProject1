using DAL.Interfaces;

namespace DAL.Entities
{
    public class MBExpensionSlots : IEntity<int>
    {
        public int Id { get; set; }
        // PCI Express version
        public string PCIExpressVersion { get; set; }
        // Count of PCI Express x16 slots
        public int CountOfPCIExX16Slots { get; set; }
        // supported PCI or CrossFire and version
        public string? SupportedPCIorCrossfire { get; set; }
        // Count of slots PCI or Crossfire
        public int? CountOfPCIorCrossfire { get; set; }
        // Count of PCI-E x1 slots
        public int? CountOfPCIExX1Slots { get; set; }

        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
