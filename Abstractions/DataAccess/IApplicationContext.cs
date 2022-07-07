using Domain.Dtos;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Abstractions.DataAccess;

/// <summary>
/// Application context interface.
/// </summary>
public interface IApplicationContext
{
    /// <summary>
    /// Ranobes.
    /// </summary>
    DbSet<Ranobe> Ranobes { get; }

    /// <summary>
    /// Product statuses.
    /// </summary>
    DbSet<StatusDto> Statuses { get; }

    /// <summary>
    /// Ranobe authors.
    /// </summary>
    DbSet<Author> Authors { get; }

    /// <summary>
    /// Save pending changes
    /// </summary>
    /// <param name="cancellationToken">Token to cancel the operation.</param>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
