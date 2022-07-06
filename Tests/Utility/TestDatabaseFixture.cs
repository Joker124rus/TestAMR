using DataAccess;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Tests.Utility;
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
                            EnglishName = "Death Note",
                            Status = context.Statuses.First(status => status.Id == Status.Ongoing)
                        },
                        new Ranobe
                        {
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