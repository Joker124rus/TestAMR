namespace Domain.Models;

/// <summary>
/// Product type.
/// </summary>
public class Type
{
    /// <summary>
    /// Identifier.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Type name.
    /// </summary>
    public string? Name { get; init; }
}