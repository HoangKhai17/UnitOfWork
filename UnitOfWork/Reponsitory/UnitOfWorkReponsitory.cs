using UnitOfWork.Controllers;
using UnitOfWork.Interface;
using UnitOfWork.Models;

namespace UnitOfWork.Reponsitory;

public class UnitOfWorkReponsitory : IUnitOfWork
{
    public ICategoryReponsitory categoryReponsitory { get; private set; }

    private readonly DatabaseContext databaseContext;

    public UnitOfWorkReponsitory(DatabaseContext _databaseContext)
    {
        this.databaseContext = _databaseContext;
        categoryReponsitory = new CategoryReponsitory(databaseContext);
    }
    public async Task CompleteAsync()
    {
        this.databaseContext.SaveChangesAsync();
    }
}
