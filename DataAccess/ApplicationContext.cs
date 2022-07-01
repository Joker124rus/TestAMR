using Abstractions.DataAccess;
using Domain.Dtos;
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
        // Database.EnsureCreated();
    }

    /// <inheritdoc />
    public DbSet<Ranobe> Ranobes { get; protected set; }

    /// <inheritdoc />
    public DbSet<StatusDto> Statuses { get; protected set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var status in Enum.GetValues(typeof(Status)).Cast<Status>())
        {
            var statusDto = new StatusDto
            {
                Id = status,
                Name = status.ToString(),
            };

            modelBuilder.Entity<StatusDto>().HasData(statusDto);
        }
    }
}
