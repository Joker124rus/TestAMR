using DataAccess;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace UnitTests.Utility;
public class TestDatabaseFixture
{
    private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=TestAMR_Tests;Trusted_Connection=True";

    private static readonly object _lock = new();
    private static bool _databaseInitialized;

    public TestDatabaseFixture()
    {
        lock (_lock)
        {
            if (!_databaseInitialized)
            {
                using (var context = CreateContext())
                {
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    context.Products.AddRange(
                        new Product
                        {
                            RussianName = "Тетрадь смерти",
                            OriginalName = "Death Note",
                            ProductType = context.ProductTypes.First(type => type.Id == ProductType.Anime)
                        },
                        new Product
                        {
                            RussianName = "Стальной алхимик",
                            OriginalName = "Fullmetal alchemist",
                            ProductType = context.ProductTypes.First(type => type.Id == ProductType.Anime)
                        });
                    context.SaveChanges();
                }

                _databaseInitialized = true;
            }
        }
    }

    public ApplicationContext CreateContext() => new(
            new DbContextOptionsBuilder<ApplicationContext>()
                .UseSqlServer(ConnectionString)
                .Options);
}