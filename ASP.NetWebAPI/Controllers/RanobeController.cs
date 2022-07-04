using Domain.Dtos;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UseCases.Ranobes;

namespace ASP.NetWebAPI.Controllers;


/// <summary>
/// Ranobe controller.
/// </summary>
[Route("api/ranobes")]
[ApiController]
public class RanobeController : ControllerBase
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    public RanobeController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Get all ranobes.
    /// </summary>
    /// <returns>IEnumerable with ranobes.</returns>
    [HttpGet]
    [Produces("application/json")]
    public async Task<IEnumerable<RanobeDto>> GetRanobesAsync(CancellationToken cancellationToken)
    {
        return await mediator.Send(new GetRanobesQuery(), cancellationToken);
    }
}
