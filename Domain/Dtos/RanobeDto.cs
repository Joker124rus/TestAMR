namespace Domain.Dtos;

/// <summary>
/// Ranobe DTO.
/// </summary>
public record RanobeDto
{
    /// <inheritdoc cref="Models.Ranobe.Id"/>
    public int Id { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Name"/>
    public string? Name { get; init; }

    /// <inheritdoc cref="Models.Ranobe.ForeignName"/>
    public string? ForeignName { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Description"/>
    public string? Description { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Chapters"/>
    public int Chapters { get; init; }

    /// <inheritdoc cref="Models.Ranobe.PublishDate"/>
    public DateTime PublishDate { get; init; }

    /// <inheritdoc cref="Models.Status"/>
    public string? Status { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Poster"/>
    public string? Poster { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Authors"/>
    public string? Authors { get; init; }
}
