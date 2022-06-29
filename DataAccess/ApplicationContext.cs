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
    public DbSet<Product> Products { get; protected set; }

    /// <inheritdoc />
    public DbSet<ProductTypeDto> ProductTypes { get; protected set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed database with all Colors
        foreach (var productType in Enum.GetValues(typeof(ProductType)).Cast<ProductType>())
        {
            var productTypeDto = new ProductTypeDto
            {
                Id = productType,
                Name = productType.ToString(),
            };

            modelBuilder.Entity<ProductTypeDto>().HasData(productTypeDto);
        }
    }
}
