using Domain.Models;

namespace Domain.Dtos;

/// <summary>
/// Status DTO.
/// </summary>
public class StatusDto
{
    /// <summary>
    /// Identifier.
    /// </summary>
    public Status Id { get; init; }

    /// <summary>
    /// Status name.
    /// </summary>
    public string? Name { get; init; }
}
