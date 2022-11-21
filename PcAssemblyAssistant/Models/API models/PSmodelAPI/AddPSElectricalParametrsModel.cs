using Models.Interfaces;

namespace Models.API_models.PSmodelAPI
{
    public class AddPSElectricalParametrsModel : IServiceResult
    {
        /// <summary>
        /// Line current +12 V
        /// </summary>
        public string? LineCurrent12V { get; set; }
        
        /// <summary>
        /// Line current +3.3 V
        /// </summary>
        public string? LineCurrent3V { get; set; }
        
        /// <summary>
        /// Line current +5 V
        /// </summary>
        public string? LineCurrent5V { get; set; }
        
        /// <summary>
        /// standby current
        /// </summary>
        public string? StandbyCurrent { get; set; }
        
        /// <summary>
        /// Line current -12 V
        /// </summary>
        public string? LineCurrentMinus12V { get; set; }
        
        /// <summary>
        /// Mains input voltage range
        /// </summary>
        public string? MainInputVoltageRange { get; set; }
    }
}
