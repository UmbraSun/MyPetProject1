using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    /// <summary>
    /// GPU cooling system
    /// </summary>
    public class GPUCoolingSystem : IEntity<int>
    {
        public int Id { get; set; }
        // GPU cooling type
        public string CoolingType { get; set; }
        // Type and number of installed fans
        public string TypeAndNumOfInstalledFans { get; set; }
        // Liquid cooling radiator
        public string LiquidCoolingRadiator { get; set; }

        // GPU
        public virtual IList<GPU> GPU { get; set; }
    }
}
