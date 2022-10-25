using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{
    public class GPUGeneralParametrs : IEntity<int>
    {
        public int Id { get; set; }
        // Name of graphic processor
        public string GraphicProcessor { get; set; }
        // Name of GPU microarchitecture
        public string Microarchitecture { get; set; }
        // process technology
        public string ProccessTechnology { get; set; }
        // INT Power consumption
        public int Сonsumption { get; set; }
        // Unit Power consumption
        public UnitsOfMeasure UnitOfСonsumption { get; set; }

        // GPU
        public virtual IList<GPU> GPU { get; set; }
    }
}
