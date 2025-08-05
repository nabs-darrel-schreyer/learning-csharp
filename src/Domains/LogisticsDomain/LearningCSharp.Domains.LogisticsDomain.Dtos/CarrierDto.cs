using CommunityToolkit.Mvvm.ComponentModel;

namespace LearningCSharp.Domains.LogisticsDomain.Dtos;

/// <summary>
/// Data Transfer Object for Carrier information
/// </summary>
public partial class CarrierDto : ObservableObject
{
    /// <summary>
    /// Unique identifier for the carrier
    /// </summary>
    [ObservableProperty]
    private string _id = string.Empty;

    /// <summary>
    /// Name of the carrier company
    /// </summary>
    [ObservableProperty]
    private string _name = string.Empty;

    /// <summary>
    /// Telephone number of the carrier
    /// </summary>
    [ObservableProperty]
    private string _telephoneNumber = string.Empty;
}
