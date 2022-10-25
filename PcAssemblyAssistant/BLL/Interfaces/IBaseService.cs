using DAL.Interfaces;

namespace BLL.Interfaces
{
    public interface IBaseService<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IList<T>> GetListAsync();
        Task<T> CreateModelAsync(T model);
        void EditModel(T model);
        void DeleteModel(T model);
    }
}
