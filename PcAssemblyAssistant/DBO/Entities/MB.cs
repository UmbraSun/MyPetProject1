using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// Motherboard class
    /// </summary>
    public class MB : IEntity<int>
    {
        public int Id { get; set; }
        // motherboard model
        public string Name { get; set; }
        // description
        public string? Description { get; set; }

        // Country
        public virtual Country? Country { get; set; }
        // motherboard form factor
        public virtual MBFormFactor? MBFormFactor { get; set; }
        // motherboard CPU and Chipset
        public virtual MbCPUandChipset? MbCPUandChipset { get; set; }
        // motherboard RAM
        public virtual MBRAM? MBRAM { get; set; }
        // motherboard Express slots
        public virtual MBExpensionSlots? MBExpensionSlots { get; set; }
        // motherboard storage device
        public virtual MBStorageDevice? MBStorageDevice { get; set; }
        // motherboard back panel
        public virtual MBBackPanel? MBBackPanel { get; set; }
        // motherboard internal connectors
        public virtual MBInternalConnectors? MBInternalConnectors { get; set; }
        // motherboard Audio adapters
        public virtual MBAudio? MBAudio { get; set; }
        // motherboard web adapters
        public virtual MBWeb? MBWeb { get; set; }
        // motherboard cooling and power
        public virtual MBCollingAndPower? MBCollingAndPower { get; set; }
    }
}
