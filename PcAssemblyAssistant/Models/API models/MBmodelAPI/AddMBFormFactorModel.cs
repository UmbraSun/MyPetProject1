using Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBFormFactorModel : IServiceResult
    {
        /// <summary>
        /// motherboard form factor
        /// </summary>
        public string FormFactor { get; set; }
        
        /// <summary>
        /// motherboard height mm
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of Height cannot be.")]
        public int Height { get; set; }
        
        /// <summary>
        /// motherboard width mm
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Out of range. The number of Width cannot be.")]
        public int Width { get; set; }
    }
}
