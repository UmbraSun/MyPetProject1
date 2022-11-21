using Models.Interfaces;

namespace Models.API_models.PSmodelAPI
{
    public class AddPSCertificationModel : IServiceResult
    {
        /// <summary>
        /// Certificate 80 PLUS
        /// </summary>
        public string? Certificate80PLUS { get; set; }
        
        /// <summary>
        /// Power factor corrector
        /// </summary>
        public string? PowerFactorCorrection { get; set; }
        
        /// <summary>
        /// Protection Technologies
        /// </summary>
        public string? ProtectionTechnologies { get; set; }
    }
}
