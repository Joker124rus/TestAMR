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

                    context.Ranobes.AddRange(
                        new Ranobe
                        {
                            RussianName = "Тетрадь смерти",
                            EnglishName = "Death Note",
                            Status = context.Statuses.First(status => status.Id == Status.OnGoing)
                        },
                        new Ranobe
                        {
                            RussianName = "Стальной алхимик",
                            EnglishName = "Fullmetal alchemist",
                            Status = context.Statuses.First(status => status.Id == Status.Complete)
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