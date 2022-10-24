using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class MbCPUandChipset : IEntity<int>
    {
        public int Id { get; set; }
        // motherboard socket
        public string Socket { get; set; }
        // motherboard CPU chipset
        public string Chipset { get; set; }
        // stirpes of compatible processors
        public string CPUStirpes { get; set; }

        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
