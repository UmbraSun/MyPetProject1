using DAL.Interfaces;

namespace DAL.Entities
{
    public class Country : IEntity<int>
    {
        public int Id { get; set; }
        
        // Country Name
        public string Name { get; set; }
    }
}
