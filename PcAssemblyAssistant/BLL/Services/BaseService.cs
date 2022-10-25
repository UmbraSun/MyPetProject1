using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using Models.Interfaces;

namespace BLL.Services
{
    /// <summary>
    /// Base service
    /// </summary>
    /// <typeparam name="R">Entity model</typeparam>
    /// <typeparam name="T">View model</typeparam>
    public class BaseService<R, T> : IBaseService<T>
        where R : class, IEntity<int>
        where T : class, IServiceResult
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IMapper _mapper;
        protected readonly IRepository<R> _repository;

        public BaseService(IUnitOfWork uow, IMapper mapper, IRepository<R> repository)
        {
            _uow = uow;
            _mapper = mapper;
            _repository = _uow.GetRepository<R>();
        }

        /// <summary>
        /// Create model in db
        /// </summary>
        /// <param name="model">View model</param>
        /// <returns></returns>
        public virtual async Task<T> CreateModelAsync(T model)
        {
            var result = await _repository.CreateAsync(_mapper.Map<R>(model));
            await _repository.SaveAsync();
            return _mapper.Map<T>(result);
        }

        /// <summary>
        /// Delete model from db
        /// </summary>
        /// <param name="model">View model</param>
        public virtual void DeleteModel(T model)
        {
            _repository.Delete(_mapper.Map<R>(model));
            _repository.SaveAsync();
        }

        /// <summary>
        /// Edit model in db
        /// </summary>
        /// <param name="model">View model</param>
        public virtual void EditModel(T model)
        {
            _repository.Edit(_mapper.Map<R>(model));
        }

        /// <summary>
        /// Get model by id from db
        /// </summary>
        /// <param name="id">model id</param>
        /// <returns></returns>
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return _mapper.Map<T>(await _repository.GetByIdAsync(id));
        }

        /// <summary>
        /// Get list of model from db
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<T>> GetListAsync()
        {
            var result = await _repository.GetAsync();
            return result.Select(x => _mapper.Map<T>(x)).ToList();
        }
    }
}
