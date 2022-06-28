namespace Domain.Models;

/// <summary>
/// Product.
/// </summary>
public class Product
{
    /// <summary>
    /// Identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Original name.
    /// </summary>
    public string OriginalName { get; init; }

    /// <summary>
    /// Japanese name.
    /// </summary>
    public string JapaneseName { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    public string Description { get; init; }
}
