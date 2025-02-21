using UnitOfWork.Interface;

namespace UnitOfWork.Controllers;

public interface IUnitOfWork
{
    ICategoryReponsitory categoryReponsitory { get; }

    Task CompleteAsync();
}
