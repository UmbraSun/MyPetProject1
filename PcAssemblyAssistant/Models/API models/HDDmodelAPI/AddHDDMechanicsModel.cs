using Models.Interfaces;

namespace Models.API_models.HDDmodelAPI
{
    public class AddHDDMechanicsModel : IServiceResult
    {
        /// <summary>
        /// Recording technology
        /// </summary>
        public string RecordingTechnology { get; set; }
        
        /// <summary>
        /// Shock resistance at work
        /// </summary>
        public string ShockResistAtWork { get; set; }
        
        /// <summary>
        /// Noise level during operation
        /// </summary>
        public string NoiseLevelDuring { get; set; }
        
        /// <summary>
        /// Noise level in idle
        /// </summary>
        public string NoiseLevelInIdle { get; set; }
    }
}
