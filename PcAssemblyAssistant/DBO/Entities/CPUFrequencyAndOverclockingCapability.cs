using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class CPUFrequencyAndOverclockingCapability : IEntity<int>
    {
        public int Id { get; set; }
        // Base int Frequency
        public int Frequency { get; set; }
        // Base unit Frenquecy
        public UnitsOfMeasure UnitFrequecy { get; set; }
        // Maximum int Frequency in Turbo mode
        public int? MaxFrequencyInTurbo { get; set; }
        // Maximum unit Frequency in Turbo mode
        public UnitsOfMeasure? UnitMaxFrequencyInTurbo { get; set; }
        // Base int Frequency of energy efficient Cores 
        public int? FrequencyOfEfficientCores { get; set; }
        // Base unit Frequency of energy efficient Cores
        public UnitsOfMeasure? UnitFrequencyOfEfficientCores { get; set; }
        // Maximum int Frequency in Turbo mode of energy efiicient Cores
        public int? MaxFrequencyTurboOfEfficientCores { get; set; }
        // Maximum unit Frequency in Turbo mode of energy efiicient Cores
        public UnitsOfMeasure? UnitMaxFrequencyTurboOfEfficientCores { get; set; }
        // Free Multiplier
        public bool FreeMultiplier { get; set; }

        // CPU
        public virtual IList<CPU> CPU { get; set; }
    }
}
