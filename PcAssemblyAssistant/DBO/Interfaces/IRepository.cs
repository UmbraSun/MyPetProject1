namespace DAL.Interfaces
{
    public interface IRepository<T> 
        where T : class, IEntity<int>
    {
        public Task<T> CreateAsync(T model);
        public Task<T> GetByIdAsync(int id);
        public Task<IList<T>> GetAsync(Func<T, bool> predicate = null);
        public void Delete(T model);
        public void Edit(T model);
        public Task SaveAsync();
    }
}
