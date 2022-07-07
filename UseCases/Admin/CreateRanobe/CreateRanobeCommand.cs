using Domain.Models;
using MediatR;

namespace UseCases.Admin.CreateRanobe;

/// <summary>
/// Create ranobe command.
/// </summary>
public record CreateRanobeCommand(Ranobe Ranobe) : IRequest;
