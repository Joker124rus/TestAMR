using System.ComponentModel.DataAnnotations;
using Domain.Models;

namespace Domain.Dtos;

/// <summary>
/// Product status DTO.
/// </summary>
public class ProductStatusDto
{
    /// <summary>
    /// Identifier.
    /// </summary>
    public ProductStatus Id { get; init; }

    /// <summary>
    /// Status name.
    /// </summary>
    public string? Name { get; init; }
}
