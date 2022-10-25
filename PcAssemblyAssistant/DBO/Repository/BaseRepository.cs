using DAL.DbContext;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    /// <summary>
    /// Base repository
    /// </summary>
    /// <typeparam name="T">Entity model</typeparam>
    public class BaseRepository<T> : IRepository<T>
        where T : class, IEntity<int>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _set;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        /// <summary>
        /// Create model in db
        /// </summary>
        /// <param name="model">Data model</param>
        /// <returns></returns>
        public async Task<T> CreateAsync(T model)
        {
            await _set.AddAsync(model);
            return model;
        }

        /// <summary>
        /// Delete model from db
        /// </summary>
        /// <param name="model">Data model</param>
        public void Delete(T model) => _set.Remove(model);

        /// <summary>
        /// Edit model in db
        /// </summary>
        /// <param name="model">Data model</param>
        public void Edit(T model) => _set.Update(model);

        /// <summary>
        /// get list of model from db
        /// </summary>
        /// <param name="predicate">Condition for models</param>
        /// <returns></returns>
        public virtual async Task<IList<T>> GetAsync(Func<T, bool> predicate = null)
        {
            return await _set.Where(predicate).AsQueryable().ToListAsync();
        }

        /// <summary>
        /// Get model by id from db
        /// </summary>
        /// <param name="id">Model id</param>
        /// <returns></returns>
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _set.FindAsync(id); 
        }

        /// <summary>
        /// Save changes in db
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
