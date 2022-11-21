using Models.Interfaces;

namespace Models.API_models.MBmodelAPI
{
    public class AddMbCPUandChipsetModel : IServiceResult
    {
        /// <summary>
        /// motherboard socket
        /// </summary>
        public string Socket { get; set; }
        
        /// <summary>
        /// motherboard CPU chipset
        /// </summary>
        public string Chipset { get; set; }
        
        /// <summary>
        /// stirpes of compatible processors
        /// </summary>
        public string CPUStirpes { get; set; }
    }
}
