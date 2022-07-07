using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UseCases.Admin.CreateRanobe;

namespace ASP.NetWebAPI.Controllers;

/// <summary>
/// Controller to administration panel.
/// </summary>
[Route("api/admin")]
[ApiController]
public class AdminController : Controller
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    public AdminController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Create
    /// </summary>
    /// <param name="ranobe"></param>
    /// <param name="cancellationToken">Token to cancel the operation.</param>
    [HttpPost]
    public async void CreateRanobeAsync(Ranobe ranobe, CancellationToken cancellationToken)
    {
        await mediator.Send(new CreateRanobeCommand(ranobe), cancellationToken);
    }
}
