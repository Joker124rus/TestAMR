using Abstractions.DataAccess;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

/// <summary>
/// Data access context.
/// </summary>
public class ApplicationContext : DbContext, IApplicationContext
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    /// <inheritdoc />
    public DbSet<Product> Products { get; init; }
}
