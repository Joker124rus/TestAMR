using Abstractions.DataAccess;
using AutoMapper;
using Domain.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace UseCases.Ranobes.GetRanobeById;

/// <summary>
/// Get ranobe by id query handler.
/// </summary>
internal class GetRanobeByIdQueryHandler : IRequestHandler<GetRanobeByIdQuery, RanobeDto>
{
    private readonly IApplicationContext db;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GetRanobeByIdQueryHandler(IApplicationContext db, IMapper mapper)
    {
        this.db = db;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<RanobeDto> Handle(GetRanobeByIdQuery request, CancellationToken cancellationToken)
    {

        var ranobe = await db.Ranobes
            .Include(ranobe => ranobe.Status)
            .Include(ranobe => ranobe.Authors)
            .FirstAsync(ranobe => ranobe.Id == request.Id, cancellationToken);

        return mapper.Map<RanobeDto>(ranobe);
    }
}
