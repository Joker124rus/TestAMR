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
    /// Russian name.
    /// </summary>
    public string RussianName { get; init; }

    /// <summary>
    /// Official non-japanese name.
    /// </summary>
    public string OriginalName { get; init; }

    /// <summary>
    /// Official japanese name.
    /// </summary>
    public string JapaneseName { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    public string Description { get; init; }
}
