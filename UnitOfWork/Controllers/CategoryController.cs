using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Models;

namespace UnitOfWork.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IUnitOfWork unitOfWork;
    public CategoryController(IUnitOfWork _unitOfWork)
    {
        this.unitOfWork = _unitOfWork;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var _data = await this.unitOfWork.categoryReponsitory.GetAllAsync();
        return Ok(_data);
    }

    [HttpGet("getById/{id}")]
    public async Task<IActionResult> getById(int id)
    {
        var _data = await this.unitOfWork.categoryReponsitory.GetAsync(id);
        return Ok(_data);
    }


    // created
    [HttpPost("created")]
    public async Task<IActionResult> created(Category category)
    {
        var _data = await this.unitOfWork.categoryReponsitory.AddEntity(category);
        await this.unitOfWork.CompleteAsync();
        return Ok(_data);
    }
    // update
    [HttpPut("update")]
    public async Task<IActionResult> update(Category category)
    {
        var _data = await this.unitOfWork.categoryReponsitory.UpdateEntity(category);
        await this.unitOfWork.CompleteAsync();
        return Ok(_data);
    }
}
