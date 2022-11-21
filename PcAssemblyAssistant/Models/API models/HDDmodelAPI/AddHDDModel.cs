using Models.Interfaces;

namespace Models.API_models.HDDmodelAPI
{
    public class AddHDDModel : IServiceResult
    {
        /// <summary>
        /// HDD Model
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Producer country Id
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// HDD additionally info
        /// </summary>
        public AddHDDAdditionallyModel? AddHDDAdditionallyModel { get; set; }

        /// <summary>
        /// HDD mechanics
        /// </summary>
        public AddHDDMechanicsModel? AddHDDMechanicsModel { get; set; }

        /// <summary>
        /// HDD storage device
        /// </summary>
        public AddHDDStorageDeviceModel? AddHDDStorageDeviceModel { get; set; }
    }
}
