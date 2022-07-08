using Domain.Dtos;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UseCases.Admin.CreateRanobe;
using UseCases.Ranobes.GetRanobes;

namespace ASP.NetWebAPI.Controllers;

/// <summary>
/// Controller to administration panel.
/// </summary>
[Route("api/admin")]
[ApiController]
public class AdminController : Controller
{
    private const string JsonHeader = "application/json";

    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    public AdminController(IMediator mediator)
    {
        this.mediator = mediator;
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


    /// <summary>
    /// Create ranobe.
    /// </summary>
    /// <param name="ranobeDto">Ranobe to create.</param>
    /// <param name="cancellationToken">Token to cancel the operation.</param>
    [HttpPost]
    public async Task CreateRanobeAsync(RanobeDto ranobeDto, CancellationToken cancellationToken)
    {
        await mediator.Send(new CreateRanobeCommand(ranobeDto), cancellationToken);
    }
}
