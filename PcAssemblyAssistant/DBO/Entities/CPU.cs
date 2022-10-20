using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class CPU : IEntity<int>
    {
        public int Id { get; set; }
        // Processor Name
        public string Name { get; set; }
        // Product Descriptions
        public string? Descriptions { get; set; }

        // Producing country
        public virtual Country Country { get; set; }
        // Processor General Parametrs
        public virtual CPUGeneralParametrs Parametrs { get; set; }
        //Processor Core and Archtecture
        public virtual CPUCoreAndArchitecture CoreAndArchitecture { get; set; }
        // Processor Frequency and Overclock Capability
        public virtual CPUFrequencyAndOverclockingCapability FrequencyAndOverclockingCapability { get; set; }
        // Processor Thermal Characteristicks
        public virtual CPUThermalCharacteristicks ThermalCharacteristicks { get; set; }
        // Integrated Graphic Processor 
        public virtual CPUGraphicsCore GPU { get; set; }
        // Processor RAM options
        public virtual CPURAMoptions RAMoptions { get; set; }
    }
}
