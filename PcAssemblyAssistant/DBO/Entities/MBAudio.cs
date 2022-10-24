using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// moterboard audio adapters
    /// </summary>
    public class MBAudio : IEntity<int>
    {
        public int Id { get; set; }
        // Sound scheme
        public int? SoundScheme { get; set; }
        // Sound adapter chipset
        public string? SouncAdapterChipset { get; set; }

        // motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
