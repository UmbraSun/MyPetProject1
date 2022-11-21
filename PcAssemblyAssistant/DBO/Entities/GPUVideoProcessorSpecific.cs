using Common.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// GPU video processor specific
    /// </summary>
    public class GPUVideoProcessorSpecific : IEntity<int>
    {
        public int Id { get; set; }
        // GPU int nominal frequency of the video chip
        public int NominalFrequencyOfTheVideoChip { get; set; }
        // GPU unit nominal frequency of the video chip
        public UnitsOfMeasure UnitNominalFreqOfTheVideoChip { get; set; }
        // GPU int turbo frequency
        public int TurboFrequency { get; set; }
        // GPU unit turbo frequency
        public UnitsOfMeasure UnitTurboFrequency { get; set; }
        // Number of universal processors
        public int NumOfUniversalProcessors { get; set; }
        // number of texture units
        public int NumOfTextureUnits { get; set; }
        // number of ROPs
        public int? NumOfROPs { get; set; }
        // GPU have ray tracing support
        public bool RayTracingSupport { get; set; }
        // Hardware accelerated ray tracing
        public int HardwareAcceleratedRayTracing { get; set; }
        // Number of tensor cores
        public int TensorCores { get; set; }
        // shader version
        public float ShaderVersion { get; set; }
        
        // GPU
        public virtual IList<GPU> GPU { get; set; }
    }
}
