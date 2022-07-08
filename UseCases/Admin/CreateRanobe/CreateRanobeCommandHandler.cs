using Abstractions.DataAccess;
using Domain.Models;
using MediatR;

namespace UseCases.Admin.CreateRanobe;

/// <summary>
/// Create ranobe command handler.
/// </summary>
internal class CreateRanobeCommandHandler : AsyncRequestHandler<CreateRanobeCommand>
{
    private readonly IApplicationContext db;

    /// <summary>
    /// Constructor.
    /// </summary>
    public CreateRanobeCommandHandler(IApplicationContext db)
    {
        this.db = db;
    }

    /// <inheritdoc />
    protected override async Task Handle(CreateRanobeCommand request, CancellationToken cancellationToken)
    {
        var ranobeDto = request.RanobeDto;

        var ranobe = new Ranobe
        {
            Name = ranobeDto.Name,
            ForeignName = ranobeDto.ForeignName,
            Description = ranobeDto.Description,
            Chapters = ranobeDto.Chapters,
            PublishDate = ranobeDto.PublishDate,
            Status = db.Statuses.First(status => status.Name!.Equals(ranobeDto.Status)),
            Poster = ranobeDto.Poster
        };

        db.Ranobes.Add(ranobe);
        await db.SaveChangesAsync(cancellationToken);
    }
}
