using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// HDD mechanics and reliability
    /// </summary>
    public class HDDMechanicsAndReliability : IEntity<int>
    {
        public int Id { get; set; }
        // Recording technology
        public string RecordingTechnology { get; set; }
        // Shock resistance at work
        public string ShockResistAtWork { get; set; }
        // Noise level during operation
        public string NoiseLevelDuring { get; set; }
        // Noise level in idle
        public string NoiseLevelInIdle { get; set; }

        // HDD
        public virtual IList<HDD> HDD { get; set; }
    }
}
