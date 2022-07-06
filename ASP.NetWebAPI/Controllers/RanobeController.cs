using Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UseCases.Ranobes.GetRanobeById;
using UseCases.Ranobes.GetRanobes;

namespace ASP.NetWebAPI.Controllers;


/// <summary>
/// Ranobe controller.
/// </summary>
[Route("api/ranobes")]
[ApiController]
public class RanobeController : ControllerBase
{
    private const string JsonHeader = "application/json";

    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    public RanobeController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Get ranobe by id.
    /// </summary>
    /// <param name="query">Query with id.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Ranobe DTO.</returns>
    [HttpGet("{Id}")]
    [Produces(JsonHeader)]
    public async Task<RanobeDto> GetRanobeByIdAsync([FromRoute] GetRanobeByIdQuery query, CancellationToken cancellationToken)
    {
        return await mediator.Send(query, cancellationToken);
    }

    /// <summary>
    /// Get all ranobes.
    /// </summary>
    /// <returns>IEnumerable with ranobes.</returns>
    [HttpGet]
    [Produces(JsonHeader)]
    public async Task<IEnumerable<RanobeDto>> GetRanobesAsync(CancellationToken cancellationToken)
    {
        return await mediator.Send(new GetRanobesQuery(), cancellationToken);
    }
}
