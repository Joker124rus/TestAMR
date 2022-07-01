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
    /// Data base set that represents ranobes.
    /// </summary>
    DbSet<Ranobe> Ranobes { get; }

    /// <summary>
    /// Product statuses.
    /// </summary>
    DbSet<StatusDto> Statuses { get; }
}
