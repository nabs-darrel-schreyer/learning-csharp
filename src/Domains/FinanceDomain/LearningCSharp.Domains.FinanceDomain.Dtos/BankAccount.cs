using CommunityToolkit.Mvvm.ComponentModel;

namespace LearningCSharp.Domains.FinanceDomain.Dtos;

/// <summary>
/// Data Transfer Object for Bank Account information
/// </summary>
public partial class BankAccount : ObservableObject
{
    /// <summary>
    /// Unique identifier for the bank account
    /// </summary>
    [ObservableProperty]
    private string _id = string.Empty;

    /// <summary>
    /// The account number
    /// </summary>
    [ObservableProperty]
    private string _accountNumber = string.Empty;

    /// <summary>
    /// Name of the account holder
    /// </summary>
    [ObservableProperty]
    private string _accountHolder = string.Empty;

    /// <summary>
    /// Date when the account was opened
    /// </summary>
    [ObservableProperty]
    private DateTime _dateOpened;
}
