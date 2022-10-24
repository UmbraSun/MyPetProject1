using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// SSD spped characteristics and power consumption
    /// </summary>
    public class SSDSpeedAndPowerConsumption : IEntity<int>
    {
        public int Id { get; set; }
        // Maximum Sequential Read Speed
        public string MaxSequentialReadSpeed { get; set; }
        // Maximum sequebtial Write Soeed
        public string MaxSequentialWriteSpeed { get; set; }
        // Random read speed of 4 KB files (IOPS - Number of I/O operations per second)
        public int RandomReadSpeedOf4KBFiles { get; set; }
        // Random write speed of 4 KB files (IOPS - Number of I/O operations per second)
        public int RandomWriteSpeedOf4KBFiles { get; set; }
        // Energy FLOAT consumption
        public float EnergyConsumption { get; set; }
        // Energy UNIT consumption
        public UnitsOfMeasure UnitEnergyConsumption { get; set; }

        // SSD
        public virtual IList<SSD> SSD { get; set; }
    }
}
