using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    /// <summary>
    /// GPU video memory specification
    /// </summary>
    public class GPUVideoMemorySpecific : IEntity<int>
    { 
        public int Id { get; set; }
        // GPU int video memory size
        public int VideoMemorySize { get; set; }
        // GPU unit video memory size
        public UnitsOfMeasure UnitOfVideoMemorySize { get; set; }
        // GPU Memory Type
        public string MemoryType { get; set; }
        // GPU memory bus widht
        public string MemoryBusWidht { get; set; }
        // GPU maximum memory bandwith
        public string MaxMemoryBandwidth { get; set; }
        // GPU int effictive memory frequency
        public int EffectiveMemoryFrequency { get; set; }
        // GPU unit effictive memory frequency
        public UnitsOfMeasure UnitOfEffectiveMemoryFrequency { get; set; }

        // GPU
        public virtual IList<GPU> GPU { get; set; }
    }
}
