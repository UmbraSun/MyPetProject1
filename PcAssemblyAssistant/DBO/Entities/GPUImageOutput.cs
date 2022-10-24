using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// GPU image output
    /// </summary>
    public class GPUImageOutput : IEntity<int>
    {
        public int Id { get; set; }
        // video connectors
        public string VideoConnectors { get; set; }
        // Display port version
        public float DisplayPortVersion { get; set; }
        // Number of monitors connected at the same time
        public int NumOfMonitorConnect { get; set; }
        // Maximum resolution
        public string MaxResolution { get; set; }

        // GPU
        public virtual IList<GPU> GPU { get; set; }
    }
}
