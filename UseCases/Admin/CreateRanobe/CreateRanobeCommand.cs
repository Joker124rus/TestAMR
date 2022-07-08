using Domain.Dtos;
using Domain.Models;
using MediatR;

namespace UseCases.Admin.CreateRanobe;

/// <summary>
/// Create ranobe command.
/// </summary>
public record CreateRanobeCommand(RanobeDto RanobeDto) : IRequest;
