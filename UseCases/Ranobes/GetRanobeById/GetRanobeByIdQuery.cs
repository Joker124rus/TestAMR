using Domain.Dtos;
using MediatR;

namespace UseCases.Ranobes.GetRanobeById;

/// <summary>
/// Get ranobe by id query.
/// </summary>
/// <param name="Id">Ranobe id.</param>
public record GetRanobeByIdQuery(int Id) : IRequest<RanobeDto>;
