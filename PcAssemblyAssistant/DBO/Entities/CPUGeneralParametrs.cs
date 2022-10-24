using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
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

        // CPU
        public virtual IList<CPU> CPU { get; set; }
    }
}
