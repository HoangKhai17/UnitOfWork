using UnitOfWork.Models;

namespace UnitOfWork.Interface;

public interface ICategoryReponsitory : IGenericRepository<Category>
{
    Task<bool> AddEntity(Category entity);
}
