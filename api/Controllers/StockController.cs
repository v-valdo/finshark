using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;
[Route("api/stock")]
[ApiController]
public class StockController : ControllerBase
{
    private readonly ApiDbContext _db;
    public StockController(ApiDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var stocks = _db.Stocks.ToList();
        return Ok(stocks);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var stock = _db.Stocks.Find(id);
        if (stock == null)
        {
            return NotFound();
        }
        return Ok(stock);
    }
}