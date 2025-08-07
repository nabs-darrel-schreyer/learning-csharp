using CommunityToolkit.Mvvm.ComponentModel;

namespace LearningCSharp.Domains.HumanResourcesDomain.Dtos;

/// <summary>
/// Data Transfer Object for Employee information
/// </summary>
public partial class Employee : ObservableObject
{
    /// <summary>
    /// Unique identifier for the employee
    /// </summary>
    [ObservableProperty]
    private string _id = string.Empty;

    /// <summary>
    /// Employee identification number with a 10 character limit
    /// </summary>
    [ObservableProperty]
    private string _employeeNumber = string.Empty;

    /// <summary>
    /// First name of the employee
    /// </summary>
    [ObservableProperty]
    private string _firstName = string.Empty;

    /// <summary>
    /// Last name of the employee. Only max 50 characters allowed.
    /// </summary>
    [ObservableProperty]
    private string _lastName = string.Empty;

    /// <summary>
    /// Email address of the employee
    /// </summary>
    [ObservableProperty]
    private string _email = string.Empty;

    /// <summary>
    /// Job title or position of the employee
    /// </summary>
    [ObservableProperty]
    private string _jobTitle = string.Empty;

    /// <summary>
    /// Department where the employee works
    /// </summary>
    [ObservableProperty]
    private string _department = string.Empty;

    /// <summary>
    /// Date when the employee was hired
    /// </summary>
    [ObservableProperty]
    private DateTime _hireDate;

    /// <summary>
    /// Annual salary of the employee
    /// </summary>
    [ObservableProperty]
    private decimal _salary;

    /// <summary>
    /// Indicates if the employee is currently active
    /// </summary>
    [ObservableProperty]
    private bool _isActive = true;
}
