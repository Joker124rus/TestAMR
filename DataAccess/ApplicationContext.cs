using Abstractions.DataAccess;
using Domain.Dtos;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

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

    /// <inheritdoc />
    public DbSet<ProductStatusDto> ProductStatuses { get; protected set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var productType in Enum.GetValues(typeof(ProductType)).Cast<ProductType>())
        {
            var productTypeDto = new ProductTypeDto
            {
                Id = productType,
                Name = productType.ToString(),
            };

            modelBuilder.Entity<ProductTypeDto>().HasData(productTypeDto);
        }

        foreach (var productStatus in Enum.GetValues(typeof(ProductStatus)).Cast<ProductStatus>())
        {
            var productStatusDto = new ProductStatusDto
            {
                Id = productStatus,
                Name = productStatus.ToString(),
            };

            modelBuilder.Entity<ProductStatusDto>().HasData(productStatusDto);
        }
    }
}
