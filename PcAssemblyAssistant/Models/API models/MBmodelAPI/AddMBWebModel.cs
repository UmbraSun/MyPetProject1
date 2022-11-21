using Models.Interfaces;

namespace Models.API_models.MBmodelAPI
{
    public class AddMBWebModel : IServiceResult
    {
        /// <summary>
        /// network adapter speed
        /// </summary>
        public string? NetAdapterSpeed { get; set; }
        
        /// <summary>
        /// network adapter chipset
        /// </summary>
        public string? NetAdapterChipset { get; set; }
        
        /// <summary>
        /// Built-in WiFi adapter
        /// </summary>
        public string? BuiltInWifiAdapter { get; set; }
        
        /// <summary>
        /// Wi-Fi Controller
        /// </summary>
        public string? WiFiController { get; set; }
        
        /// <summary>
        /// Bluetooth
        /// </summary>
        public string? Bluetooth { get; set; }
    }
}
