namespace Domain.Models;

/// <summary>
/// Product status.
/// </summary>
public enum ProductStatus
{
    /// <summary>
    /// Work on product is underway.
    /// </summary>
    OnGoing = 1,

    /// <summary>
    /// Product is completed.
    /// </summary>
    Complete = 2,

    /// <summary>
    /// Product is announced.
    /// </summary>
    Announce = 3,

    /// <summary>
    /// Work on product is temporarily cancelled.
    /// </summary>
    Freeze = 4,

    /// <summary>
    /// Product is cancelled.
    /// </summary>
    Deny = 5
}