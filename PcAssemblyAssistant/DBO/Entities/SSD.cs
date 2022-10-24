using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    // SSD
    public class SSD : IEntity<int>
    {
        public int Id { get; set; }
        // SSD model
        public string Name { get; set; }
        // SSD Type
        public string SSDType { get; set; }
        // description
        public string? Description { get; set; }

        // Producer country
        public Country? Country { get; set; }
        // SSD main charactericstics
        public SSDMainCharacteristics? SSDMainCharacteristics { get; set; }
        // SSD speed and power consumption
        public SSDSpeedAndPowerConsumption? SSDSpeedAndPowerConsumption { get; set; }
    }
}
