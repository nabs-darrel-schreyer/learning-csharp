namespace LearningCSharp.Domains.LogisticsDomain.Persistence.Entities;

/// <summary>
/// Persistence entity for Carrier information
/// </summary>
public class CarrierEntity
{
    /// <summary>
    /// Unique identifier for the carrier
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Name of the carrier company
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Telephone number of the carrier
    /// </summary>
    public string TelephoneNumber { get; set; } = string.Empty;
}
