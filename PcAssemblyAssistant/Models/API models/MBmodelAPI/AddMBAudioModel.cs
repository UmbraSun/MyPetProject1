using Common.Custom_Attributes;
using Models.Interfaces;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBAudioModel : IServiceResult
    {
        /// <summary>
        /// Sound scheme
        /// </summary>
        [NullOrAboveZero(ErrorMessage = "Out of range. The number of SoundScheme cannot be.")]
        public int SoundScheme { get; set; }
        
        /// <summary>
        /// Sound adapter chipset
        /// </summary>
        public string SouncAdapterChipset { get; set; }
    }
}
