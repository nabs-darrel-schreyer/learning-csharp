using CommunityToolkit.Mvvm.ComponentModel;

namespace LearningCSharp.Domains.HumanResourcesDomain.Dtos;

/// <summary>
/// Data Transfer Object for Manager information
/// </summary>
public partial class Manager : ObservableObject
{
    /// <summary>
    /// Unique identifier for the manager
    /// </summary>
    [ObservableProperty]
    private string _id = string.Empty;

    /// <summary>
    /// Manager identification number
    /// </summary>
    [ObservableProperty]
    private string _managerNumber = string.Empty;

    /// <summary>
    /// First name of the manager
    /// </summary>
    [ObservableProperty]
    private string _firstName = string.Empty;

    /// <summary>
    /// Last name of the manager
    /// </summary>
    [ObservableProperty]
    private string _lastName = string.Empty;

    /// <summary>
    /// Email address of the manager
    /// </summary>
    [ObservableProperty]
    private string _email = string.Empty;

    /// <summary>
    /// Management level of the manager
    /// </summary>
    [ObservableProperty]
    private string _managementLevel = string.Empty;

    /// <summary>
    /// Department that the manager oversees
    /// </summary>
    [ObservableProperty]
    private string _department = string.Empty;

    /// <summary>
    /// Number of direct reports under this manager
    /// </summary>
    [ObservableProperty]
    private int _directReportsCount;

    /// <summary>
    /// Date when the manager started in management role
    /// </summary>
    [ObservableProperty]
    private DateTime _managementStartDate;

    /// <summary>
    /// Annual salary of the manager
    /// </summary>
    [ObservableProperty]
    private decimal _salary;

    /// <summary>
    /// Indicates if the manager is currently active
    /// </summary>
    [ObservableProperty]
    private bool _isActive = true;
}
