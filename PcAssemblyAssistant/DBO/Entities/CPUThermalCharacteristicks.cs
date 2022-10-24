﻿using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// CPU thermal characteristicks
    /// </summary>
    public class CPUThermalCharacteristicks : IEntity<int>
    {
        public int Id { get; set; }
        // Processor int heat disspation 
        public int TDP { get; set; }
        // Processor unit heat disspation
        public UnitsOfMeasure UnitOfTDP { get; set; }
        // maximum processor temprature
        public int MaxCPUtemprature { get; set; }

        // CPU
        public virtual IList<CPU> CPU { get; set; }
    }
}