using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Abstractions.DataAccess;

/// <summary>
/// Application context interface.
/// </summary>
public interface IApplicationContext
{
    /// <summary>
    /// Data base set that represents products.
    /// </summary>
    DbSet<Product> Products { get; init; }
}
