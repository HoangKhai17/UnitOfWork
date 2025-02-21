using Microsoft.EntityFrameworkCore;
using UnitOfWork.Interface;
using UnitOfWork.Models;

namespace UnitOfWork.Reponsitory;

public class CategoryReponsitory : GenericReponsitory<Category>, ICategoryReponsitory
{
    public CategoryReponsitory(DatabaseContext _dbContext) : base(_dbContext)
    {

    }

    public override Task<List<Category>> GetAllAsync()
    {
        return base.GetAllAsync();
    }

    public override async Task<Category> GetAsync(int id)
    {
        return await DbSet.FirstOrDefaultAsync(item => item.Id == id);
    }

    // create category
    public override async Task<bool> AddEntity(Category entity)
    {
        try
        {
            await DbSet.AddAsync(entity);
            return true;

        }catch (Exception ex)
        {
            throw ex;
        }
    }

    // update category
    public override async Task<bool> UpdateEntity(Category entity)
    {
        try
        {
           var existData = await DbSet.FirstOrDefaultAsync(item => item.Id == entity.Id);
            if (existData != null)
            {
                existData.Name = entity.Name;
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
 
}
