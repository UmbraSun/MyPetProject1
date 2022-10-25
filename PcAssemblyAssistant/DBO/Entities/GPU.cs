using DAL.Interfaces;

namespace DAL.Entities
{
    // video card
    public class GPU : IEntity<int>
    {
        public int Id { get; set; }
        // Model
        public string Name { get; set; }
        // Description
        public string? Description { get; set; }
        // Producer Code
        public string? ProducerCode { get; set; }
        // Designed for mining
        public bool ForMining { get; set; }

        // Producer Country
        public virtual Country? Country { get; set; }
        // GPU general parametrs
        public virtual GPUGeneralParametrs? GPUGeneralParametrs { get; set; }
        // GPU video memory specification
        public virtual GPUVideoMemorySpecific? GPUVideoMemorySpecific { get; set; }
        // GPU video Processor specification
        public virtual GPUVideoProcessorSpecific? GPUVideoProcessorSpecific { get; set; }
        // GPU Image output
        public virtual GPUImageOutput? GPUImageOutput { get; set; }
        // GPU connection
        public virtual GPUConnection? GPUConnection { get; set; }
        // GPU cooling system
        public virtual GPUCoolingSystem? GPUCoolingSystem { get; set; }
    }
}
