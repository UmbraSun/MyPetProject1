using DAL.Interfaces;

namespace BLL.Interfaces
{
    public interface IBaseService<T>
    {
        Task<T> BaseGetByIdAsync(int id);
        Task<IList<T>> BaseGetListAsync();
        Task<T> BaseCreateModelAsync(T model);
        void BaseEditModel(T model);
        void BaseDeleteModel(T model);
    }
}
