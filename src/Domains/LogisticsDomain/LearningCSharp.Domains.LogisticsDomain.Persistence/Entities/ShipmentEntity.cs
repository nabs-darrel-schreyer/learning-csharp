namespace LearningCSharp.Domains.LogisticsDomain.Persistence.Entities;

/// <summary>
/// Persistence entity for Shipment information
/// </summary>
public class ShipmentEntity
{
    /// <summary>
    /// Unique identifier for the shipment
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Street number and name
    /// </summary>
    public string StreetAddress { get; set; } = string.Empty;

    /// <summary>
    /// Suburb or locality
    /// </summary>
    public string Suburb { get; set; } = string.Empty;

    /// <summary>
    /// City or town
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Region or province should be max 50 characters.
    /// </summary>
    public string Region { get; set; } = string.Empty;

    /// <summary>
    /// Postal code
    /// </summary>
    public string PostalCode { get; set; } = string.Empty;

    /// <summary>
    /// Country (defaults to New Zealand)
    /// </summary>
    public string Country { get; set; } = "New Zealand";
}
