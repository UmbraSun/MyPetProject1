using DAL.Interfaces;

namespace DAL.Entities
{
    public class MBFormFactor : IEntity<int>
    {
        public int Id { get; set; }
        //motherboard form factor
        public string FormFactor { get; set; }
        // motherboard height mm
        public int Height { get; set; }
        // motherboard width mm
        public int Width { get; set; }

        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
