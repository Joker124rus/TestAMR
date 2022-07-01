using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UseCases.Products;

namespace ASP.NetWebAPI.Controllers;


/// <summary>
/// Anime controller.
/// </summary>
[Route("api/products")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    public ProductController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Get all animes.
    /// </summary>
    /// <returns>IEnumerable with animes.</returns>
    [HttpGet]
    [Produces("application/json")]
    public async Task<IEnumerable<Product>> GetProductsAsync([FromQuery] GetProductsQuery query)
    {
        //return await mediator.Send(new GetProductsQuery(productType));
        return await mediator.Send(query);
    }
}
