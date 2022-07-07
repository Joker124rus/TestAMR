using Abstractions.DataAccess;
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
        db.Ranobes.Add(request.Ranobe);
        await db.SaveChangesAsync(cancellationToken);
    }
}
