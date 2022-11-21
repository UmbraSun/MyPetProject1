using Common.Custom_Attributes;
using Common.Enums;
using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.GPUmodelAPI
{
    public class AddGPUVideoProcessorModel : IServiceResult
    {
        /// <summary>
        /// GPU int nominal frequency of the video chip
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of NominalFrequencyOfTheVideoChip cannot be.")]
        public int NominalFrequencyOfTheVideoChip { get; set; }

        /// <summary>
        /// GPU unit nominal frequency of the video chip
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitNominalFreqOfTheVideoChip { get; set; }
        
        /// <summary>
        /// GPU int turbo frequency
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of TurboFrequency cannot be.")]
        public int TurboFrequency { get; set; }

        /// <summary>
        /// GPU unit turbo frequency
        /// </summary>
        [EnumContainValue(ErrorMessage = "Enum UnitsOfMeasure dont contain this value.")]
        public UnitsOfMeasure UnitTurboFrequency { get; set; }
        
        /// <summary>
        /// Number of universal processors
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of TurboFrequency cannot be.")]
        public int NumOfUniversalProcessors { get; set; }

        /// <summary>
        /// number of texture units
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of TurboFrequency cannot be.")]
        public int NumOfTextureUnits { get; set; }

        /// <summary>
        /// number of ROPs
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of NumOfROPs cannot be.")]
        public int? NumOfROPs { get; set; }

        /// <summary>
        /// GPU have ray tracing support
        /// </summary>
        public bool RayTracingSupport { get; set; }
        
        /// <summary>
        /// Hardware accelerated ray tracing
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of HardwareAcceleratedRayTracing cannot be.")]
        public int HardwareAcceleratedRayTracing { get; set; }
        
        /// <summary>
        /// Number of tensor cores
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of TensorCores cannot be.")]
        public int TensorCores { get; set; }

        /// <summary>
        /// shader version
        /// </summary>
        [Range(0, float.MaxValue, ErrorMessage = "Out of range. The number of ShaderVersion cannot be.")]
        public float ShaderVersion { get; set; }
    }
}
