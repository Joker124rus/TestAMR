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
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    /// <inheritdoc />
    public DbSet<Ranobe> Ranobes { get; protected set; }

    /// <inheritdoc />
    public DbSet<StatusDto> Statuses { get; protected set; }

    /// <inheritdoc />
    public DbSet<Author> Authors { get; protected set; }

    /// <inheritdoc />
    public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

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

        modelBuilder.Entity<Ranobe>().HasData(new Ranobe
        {
            Id = 1,
            Name = "Solo leveling",
            ForeignName = "나 혼자만 레벨업",
            Chapters = 160,
            Description = "10 years ago, after “the Gate” that connected the real world with the monster world opened, some of the ordinary, everyday people received the power to hunt monsters within the Gate. They are known as \"Hunters\". However, not all Hunters are powerful. My name is Sung Jin-Woo, an E-rank Hunter. I'm someone who has to risk his life in the lowliest of dungeons, the \"World's Weakest\". Having no skills whatsoever to display, I barely earned the required money by fighting in low-leveled dungeons… at least until I found a hidden dungeon with the hardest difficulty within the D-rank dungeons! In the end, as I was accepting death, I suddenly received a strange power, a quest log that only I could see, a secret to leveling up that only I know about! If I trained in accordance with my quests and hunted monsters, my level would rise. Changing from the weakest Hunter to the strongest S-rank Hunter!",
            PublishDate = new DateTime(2010, 5, 27),
            StatusId = Status.Ongoing
        });
    }
}
