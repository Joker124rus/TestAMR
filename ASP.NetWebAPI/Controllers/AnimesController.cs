using Abstractions.DataAccess;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NetWebAPI.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class AnimesController : ControllerBase
{
    private IApplicationContext db;

    public AnimesController(IApplicationContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Produces("application/json")]
    public IEnumerable<Product> GetAnimes()
    {
        return db.Products;
    }
}
