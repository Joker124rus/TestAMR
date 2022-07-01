using System.ComponentModel.DataAnnotations;
using Domain.Dtos;

namespace Domain.Models;

/// <summary>
/// Product.
/// </summary>
public class Product
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
    /// Official non-japanese name.
    /// </summary>
    [StringLength(300)]
    public string? OriginalName { get; init; }

    /// <summary>
    /// Official japanese name.
    /// </summary>
    [StringLength(300)]
    public string? JapaneseName { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    public string? Description { get; init; }

    /// <inheritdoc cref="Models.ProductType"/>
    [Required]
    public ProductTypeDto? ProductType { get; init; }

    /// <summary>
    /// Total count episodes.
    /// </summary>
    public int? CountEpisodes { get; init; }

    /// <summary>
    /// Date when product published. This represents date of first episode. 
    /// </summary>
    public DateTime? PublishDate { get; init; }

    /// <inheritdoc cref="Models.ProductStatus"/>
    [Required]
    public ProductStatusDto? ProductStatus { get; init; }



}
