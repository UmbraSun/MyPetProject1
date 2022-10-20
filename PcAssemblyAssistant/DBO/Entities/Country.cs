using DBO_DAL.Interfaces;

namespace DBO_DAL.Entities
{
    public class Country : IEntity<int>
    {
        public int Id { get; set; }
        
        // Country Name
        public string Name { get; set; }
    }
}
