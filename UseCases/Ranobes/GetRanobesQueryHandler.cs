using Abstractions.DataAccess;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace UseCases.Ranobes;

/// <summary>
/// Get products query handler.
/// </summary>
public class GetRanobesQueryHandler : IRequestHandler<GetRanobesQuery, IEnumerable<Ranobe>>
{
    private readonly IApplicationContext db;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GetRanobesQueryHandler(IApplicationContext db)
    {
        this.db = db;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<Ranobe>> Handle(GetRanobesQuery request, CancellationToken cancellationToken)
    {
        return await db.Ranobes.ToArrayAsync();
    }
}
