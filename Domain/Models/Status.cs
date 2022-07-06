namespace Domain.Models;

/// <summary>
/// Ranobe status.
/// </summary>
public enum Status
{
    /// <summary>
    /// Work on ranobe is underway.
    /// </summary>
    Ongoing = 1,

    /// <summary>
    /// Ranobe is completed.
    /// </summary>
    Complete = 2,

    /// <summary>
    /// Ranobe is announced.
    /// </summary>
    Announce = 3,

    /// <summary>
    /// Work on Ranobe is temporarily cancelled.
    /// </summary>
    Freeze = 4,

    /// <summary>
    /// Ranobe is cancelled.
    /// </summary>
    Deny = 5
}