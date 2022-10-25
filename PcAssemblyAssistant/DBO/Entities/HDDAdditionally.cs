using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// additionally
    /// </summary>
    public class HDDAdditionally : IEntity<int>
    {
        public int Id { get; set; }
        // Maximum INT power consumption
        public int MaxPowerConsumption { get; set; }
        // Maximum Unit power consumption
        public UnitsOfMeasure UnitMaxPowerConsumption { get; set; }
        // INT Standby power consumption
        public int StandbyPowerConsumpiton { get; set; }
        // Unit Standby power consumption
        public UnitsOfMeasure UnitStandbyPowerConsumpiton { get; set; }
        // Minimum operating temprature °C
        public int MinOperatingTemp { get; set; }
        // Maximum operating temrature °C
        public int MaxOperatingTemp { get; set; }
        // INT Power consumption
        public int Сonsumption { get; set; }
        // Unit Power consumption
        public UnitsOfMeasure UnitOfСonsumption { get; set; }

        // HDD
        public virtual IList<HDD> HDD { get; set; }
    }
}
