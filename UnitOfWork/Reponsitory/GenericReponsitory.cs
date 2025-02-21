using Microsoft.EntityFrameworkCore;
using UnitOfWork.Interface;
using UnitOfWork.Models;

namespace UnitOfWork.Reponsitory;

public class GenericReponsitory<T> : IGenericRepository<T> where T : class
{
    protected DatabaseContext dbContext;
    internal DbSet<T> DbSet { get; set; }
    public GenericReponsitory(DatabaseContext _dbContext)
    {
        this.dbContext = _dbContext;
        this.DbSet = this.dbContext.Set<T>();
    }

    public virtual Task<List<T>> GetAllAsync()
    {
        return DbSet.ToListAsync();
    }

    public virtual Task<T> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public virtual Task<bool> AddEntity(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual Task<bool> UpdateEntity(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual Task<bool> DeleteEntity(int id)
    {
        throw new NotImplementedException();
    }
}
