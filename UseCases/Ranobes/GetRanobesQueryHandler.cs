using Abstractions.DataAccess;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Dtos;
using MediatR;

namespace UseCases.Ranobes;

/// <summary>
/// Get products query handler.
/// </summary>
public class GetRanobesQueryHandler : IRequestHandler<GetRanobesQuery, IEnumerable<RanobeDto>>
{
    private readonly IApplicationContext db;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GetRanobesQueryHandler(IApplicationContext db, IMapper mapper)
    {
        this.db = db;
        this.mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<RanobeDto>> Handle(GetRanobesQuery request, CancellationToken cancellationToken)
    {
        var query = db.Ranobes.AsQueryable();

        return mapper.ProjectTo<RanobeDto>(query);
    }
}
