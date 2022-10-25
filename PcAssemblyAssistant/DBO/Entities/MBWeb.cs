using DAL.Interfaces;

namespace DAL.Entities
{
    public class MBWeb : IEntity<int>
    {
        public int Id { get; set; }
        // network adapter speed
        public string? NetAdapterSpeed { get; set; }
        // network adapter chipset
        public string? NetAdapterChipset { get; set; }
        // Built-in WiFi adapter
        public string? BuiltInWifiAdapter { get; set; }
        // Wi-Fi Controller
        public string? WiFiController { get; set; }
        // Bluetooth
        public string? Bluetooth { get; set; }

        // Motherboard
        public virtual IList<MB> MB { get; set; }
    }
}
