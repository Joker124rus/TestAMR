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
    /// English name.
    /// </summary>
    [Required]
    [StringLength(300)]
    public string? Name { get; init; }

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
    public int Chapters { get; init; }

    /// <summary>
    /// Date when the ranobe was published. This represents date when the first chapter was published. 
    /// </summary>
    public DateTime PublishDate { get; init; }

    /// <inheritdoc cref="Models.Status"/>
    [Required]
    public StatusDto? Status { get; init; }

    public Status StatusId { get; init; }

    /// <summary>
    /// Path to the poster.
    /// </summary>
    public string? Poster { get; init; }

    /// <summary>
    /// Rating by people.
    /// </summary>
    public double Rating { get; init; }
    
    /// <summary>
    /// Represents how much people rated this ranobe.
    /// </summary>
    public int PeopleRatedCount { get; init; }

    /// <summary>
    /// Authors.
    /// </summary>
    public List<Author>? Authors { get; init; }
}
