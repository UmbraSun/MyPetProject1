using DAL.DbContext;
using DAL.Interfaces;
using DAL.Repository;
using System.Collections.Concurrent;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly ConcurrentDictionary<Type, object> _repository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _repository = new ConcurrentDictionary<Type, object>();
        }

        /// <summary>
        /// Get the desired repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IRepository<T> GetRepository<T>()
            where T : class, IEntity<int>
        {
            return _repository.GetOrAdd(typeof(T), new BaseRepository<T>(_context)) as IRepository<T>;
        }
    }
}
