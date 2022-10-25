using DAL.Enums;
using DAL.Interfaces;

namespace DAL.Entities
{

    public class CPUGeneralParametrs : IEntity<int>
    {
        public int Id { get; set; }
        // Processor model
        public string Model { get; set; }
        // Processor socket
        public string Socket { get; set; }
        // Realise Date
        public DateTime? RealiseDate { get; set; }
        // INT Power consumption
        public int Сonsumption { get; set; }
        // Unit Power consumption
        public UnitsOfMeasure UnitOfСonsumption { get; set; }

        // CPU
        public virtual IList<CPU> CPU { get; set; }
    }
}
