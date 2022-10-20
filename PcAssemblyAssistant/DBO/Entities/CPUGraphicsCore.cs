﻿using DBO_DAL.Enums;
using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class CPUGraphicsCore : IEntity<int>
    {
        public int Id { get; set; }
        // Graphic Processor Model
        public string GPUModel { get; set; }
        // Maximum int Frequency of Graphic Cores
        public int GPUCoreFreqency { get; set; }
        // Maximum unit Frenquency of Graphic Cores
        public UnitsOfMeasure UnitOfGPUCoreFreqency { get; set; }
        // Number of Executive Blocks
        public int ExecutiveBlocks { get; set; }
    }
}
