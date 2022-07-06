namespace Domain.Models;

/// <summary>
/// Ranobe author.
/// </summary>
public class Author
{
    /// <summary>
    /// Identifier.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Author name.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Ranobes made by the author.
    /// </summary>
    public List<Ranobe>? Ranobes { get; init; }
}
