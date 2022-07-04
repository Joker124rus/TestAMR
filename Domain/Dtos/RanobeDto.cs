namespace Domain.Dtos;

/// <summary>
/// Ranobe DTO.
/// </summary>
public class RanobeDto
{
    /// <inheritdoc cref="Models.Ranobe.Id"/>
    public int Id { get; init; }

    /// <inheritdoc cref="Models.Ranobe.EnglishName"/>
    public string? EnglishName { get; init; }

    /// <inheritdoc cref="Models.Ranobe.ForeignName"/>
    public string? ForeignName { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Description"/>
    public string? Description { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Chapters"/>
    public int? Chapters { get; init; }

    /// <inheritdoc cref="Models.Ranobe.Date"/>
    public DateTime? PublishDate { get; init; }

    /// <inheritdoc cref="Models.Status"/>
    public string? Status { get; init; }
}
