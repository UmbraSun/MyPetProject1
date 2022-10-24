using DBO_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// power supply cooling system
    /// </summary>
    public class PSCoolingSystem : IEntity<int>
    {
        public int Id { get; set; }
        // Cooling system
        public string? CoolingSystem { get; set; }
        // Fan dimensions
        public string? FanDiametrs { get; set; }
        // Speed ​​control
        public string? SpeedControl { get; set; }

        // power supply
        public virtual IList<PS> PS { get; set; }
    }
}
