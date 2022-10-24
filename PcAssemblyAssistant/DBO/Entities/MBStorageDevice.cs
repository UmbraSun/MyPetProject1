using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// motherboard storage device
    /// </summary>
    public class MBStorageDevice : IEntity<int>
    {
        public int Id { get; set; }
        // count of M2 SSD
        public int? CountOfM2 { get; set; }
        // M2 SSD connectors
        public string? M2Connectors { get; set; }
        // count of port for ssd and hdd
        public int CountOfPortsSATA { get; set; }
        // Is motherboard supported NVME
        public bool SupportedNVME { get; set; }

        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
