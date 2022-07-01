using System.ComponentModel.DataAnnotations;
using Domain.Dtos;

namespace Domain.Models;

/// <summary>
/// Ranobe.
/// </summary>
public class Ranobe
{
    /// <summary>
    /// Identifier.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Russian name.
    /// </summary>
    [Required]
    [StringLength(300)]
    public string? RussianName { get; init; }

    /// <summary>
    /// English name.
    /// </summary>
    [StringLength(300)]
    public string? EnglishName { get; init; }

    /// <summary>
    /// Official foreign name.
    /// </summary>
    [StringLength(300)]
    public string? ForeignName { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Total count episodes.
    /// </summary>
    public int? ChaptersCount { get; init; }

    /// <summary>
    /// Date when ranobe is published. This represents date of first chapter. 
    /// </summary>
    public DateTime? PublishDate { get; init; }

    /// <inheritdoc cref="Models.Status"/>
    [Required]
    public StatusDto? Status { get; init; }
}
