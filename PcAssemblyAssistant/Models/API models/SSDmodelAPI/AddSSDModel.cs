using Models.Interfaces;

namespace Models.API_models.SSDmodelAPI
{
    public class AddSSDModel : IServiceResult
    {
        /// <summary>
        /// SSD model
        /// </summary>
        public string Name { get; set; }
       
        /// <summary>
        /// SSD Type
        /// </summary>
        public string SSDType { get; set; }
        
        /// <summary>
        /// description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Producer country Id
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// SSD main characteristics
        /// </summary>
        public AddSSDMainCharacteristicsModel? AddSSDMainCharacteristicsModel { get; set; } 

        /// <summary>
        /// SSD speed and power consumption
        /// </summary>
        public AddSSDSpeedModel? AddSSDSpeedModel { get; set; }
    }
}
