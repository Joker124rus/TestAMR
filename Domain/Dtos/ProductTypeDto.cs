using Domain.Models;

namespace Domain.Dtos;

/// <summary>
/// Product type DTO.
/// </summary>
public class ProductTypeDto
{
    /// <summary>
    /// Identifier.
    /// </summary>
    public ProductType Id { get; init; }

    /// <summary>
    /// Type name.
    /// </summary>
    public string? Name { get; init; }
}