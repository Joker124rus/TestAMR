using Domain.Dtos;
using MediatR;

namespace UseCases.Ranobes.GetRanobes;

/// <summary>
/// Get products query with specified type.
/// </summary>
public record GetRanobesQuery : IRequest<IEnumerable<RanobeDto>>;
