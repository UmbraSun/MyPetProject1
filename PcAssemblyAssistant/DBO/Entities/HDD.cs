using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// HDD
    /// </summary>
    public class HDD : IEntity<int>
    {
        public int Id { get; set; }
        // HDD Model
        public string Name { get; set; }
        // Description
        public string? Description { get; set; }

        // Country
        public virtual Country? Country { get; set; }
        // Storage device
        public virtual HDDStorageDevice? HDDStorageDevice { get; set; }
        // HDD Mechanics And Reliability
        public virtual HDDMechanicsAndReliability? HDDMechanicsAndReliability { get; set; }
        // HDD additionally
        public virtual HDDAdditionally? HDDAdditionally { get; set; }
    }
}
