using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{   
    /// <summary>
    /// RAM timings
    /// </summary>
    public class RAMTimings : IEntity<int>
    {
        public int Id { get; set; }
        // CAS latency
        public int CASLatency { get; set; }
        // RAS to CAS Delay 
        public int RAStoCASDelay { get; set; }
        // Row Precharge Delay
        public int RowPrechangeDelay { get; set; }

        // RAM
        public virtual IList<RAM> RAM { get; set; }
    }
}
