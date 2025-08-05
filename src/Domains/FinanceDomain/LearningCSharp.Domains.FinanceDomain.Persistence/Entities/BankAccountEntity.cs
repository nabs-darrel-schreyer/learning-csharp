namespace LearningCSharp.Domains.FinanceDomain.Persistence.Entities;

/// <summary>
/// Persistence entity for Bank Account information
/// </summary>
public class BankAccountEntity
{
    /// <summary>
    /// Unique identifier for the bank account
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// The account number
    /// </summary>
    public string AccountNumber { get; set; } = string.Empty;

    /// <summary>
    /// Name of the account holder
    /// </summary>
    public string AccountHolder { get; set; } = string.Empty;

    /// <summary>
    /// Date when the account was opened
    /// </summary>
    public DateTime DateOpened { get; set; }

    /// <summary>
    /// Date and time when this entity was created
    /// </summary>
    public DateTime CreatedOn { get; set; }
}
