using Domain.Dtos;
using Domain.Models;
using MediatR;

namespace UseCases.Ranobes;

/// <summary>
/// Get products query with specified type.
/// </summary>
public record GetRanobesQuery : IRequest<IEnumerable<RanobeDto>>;
