using CommunityToolkit.Mvvm.ComponentModel;

namespace LearningCSharp.Domains.LogisticsDomain.Dtos;

/// <summary>
/// Data Transfer Object for Shipment information
/// </summary>
public partial class ShipmentDto : ObservableObject
{
    /// <summary>
    /// Unique identifier for the shipment
    /// </summary>
    [ObservableProperty]
    private string _id = string.Empty;

    /// <summary>
    /// Street number and name
    /// </summary>
    [ObservableProperty]
    private string _streetAddress = string.Empty;

    /// <summary>
    /// Suburb or locality
    /// </summary>
    [ObservableProperty]
    private string _suburb = string.Empty;

    /// <summary>
    /// City or town
    /// </summary>
    [ObservableProperty]
    private string _city = string.Empty;

    /// <summary>
    /// Region or province
    /// </summary>
    [ObservableProperty]
    private string _region = string.Empty;

    /// <summary>
    /// Postal code
    /// </summary>
    [ObservableProperty]
    private string _postalCode = string.Empty;

    /// <summary>
    /// Country (defaults to New Zealand)
    /// </summary>
    [ObservableProperty]
    private string _country = "New Zealand";
}
