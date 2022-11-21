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

        public BaseService(IUnitOfWork uow, IMapper mapper)
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
        public async Task<T> BaseCreateModelAsync(T model)
        {
            var result = await _repository.CreateAsync(_mapper.Map<R>(model));
            await _repository.SaveAsync();
            return _mapper.Map<T>(result);
        }

        /// <summary>
        /// Delete model from db
        /// </summary>
        /// <param name="model">View model</param>
        public void BaseDeleteModel(T model)
        {
            _repository.Delete(_mapper.Map<R>(model));
            _repository.SaveAsync();
        }

        /// <summary>
        /// Edit model in db
        /// </summary>
        /// <param name="model">View model</param>
        public void BaseEditModel(T model)
        {
            _repository.Edit(_mapper.Map<R>(model));
        }

        /// <summary>
        /// Get model by id from db
        /// </summary>
        /// <param name="id">model id</param>
        /// <returns></returns>
        public async Task<T> BaseGetByIdAsync(int id)
        { 
            return _mapper.Map<T>(await _repository.GetByIdAsync(id));
        }

        /// <summary>
        /// Get list of model from db
        /// </summary>
        /// <returns></returns>
        public async Task<IList<T>> BaseGetListAsync()
        {
            var result = await _repository.GetAsync();
            return result.Select(x => _mapper.Map<T>(x)).ToList();
        }

        /// <summary>
        /// model add entity check
        /// </summary>
        protected virtual void Check() { }
        
        /// <summary>
        /// manipulation with data before add in db
        /// </summary>
        protected virtual void BeforeAdd() { }
    }
}
