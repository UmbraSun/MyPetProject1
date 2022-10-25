using DAL.Interfaces;

namespace DAL.Entities
{
    // power supply certification
    public class PSCertification : IEntity<int>
    {
        public int Id { get; set; }
        // Certificate 80 PLUS
        public string? Certificate80PLUS { get; set; }
        // Power factor corrector
        public string? PowerFactorCorrection { get; set; }
        // Protection Technologies
        public string? ProtectionTechnologies { get; set; }

        // power supply
        public virtual IList<PS> PS { get; set; }
    }
}
