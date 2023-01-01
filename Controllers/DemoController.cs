using Microsoft.AspNetCore.Mvc;
using EnumDemo.Data;
using EnumDemo.Entities;

namespace EnumDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public DemoController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<MyEntity>> Get()
    {
        var entity = new MyEntity
        {
            Id = 123,
            Value = MyEnum.FooBar,
        };

        _ = _dbContext.Add(entity);

        _ = await _dbContext.SaveChangesAsync();

        return Ok(entity);
    }
}
