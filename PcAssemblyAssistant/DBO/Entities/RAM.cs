using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    // RAM
    public class RAM : IEntity<int>
    {
        public int Id { get; set; }
        // RAM model
        public string Name { get; set; }
        // RAM description
        public string? Description { get; set; }
        // RAM producer code
        public string? ProducerCode { get; set; }

        // Ram producer country
        public virtual Country? Country { get; set; }
        // RAM volume and composition of the kit
        public virtual RAMKitVolumeAndComposition? RAMKitVolumeAndComposition { get; set; }
        // RAM Performance
        public virtual RAMPerformance? RAMPerformance { get; set; }
        // RAM timings
        public virtual RAMTimings? RAMTimings { get; set; }
    }
}
