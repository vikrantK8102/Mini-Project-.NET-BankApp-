using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp;

// Defines a class representing a bank account
public class BankAccount
{
    // Property to store the owner's name
    public string owner { get; set; }

    // Property to store the unique account number (GUID)
    public Guid AccountNumber { get; set; }

    // Property to store the account balance; can only be set within this class or subclasses
    public decimal Balance { get; protected set; }

    // Constructor to initialize the account with owner name, a new GUID, and 0 balance
    public BankAccount(string own)
    {
        owner = own;
        AccountNumber = Guid.NewGuid();
        Balance = 0;
    }

    // Method to deposit money into the account
    public virtual string Deposit(decimal amount)
    {
        // Check for invalid deposit amount
        if (amount <= 0) return $"you cannot deposit Rs.{amount}";

        // Check if deposit exceeds AML (Anti-Money Laundering) limit
        if (amount > 20000) return "AML desposit limit is reached.";

        // Update balance
        Balance = Balance + amount;

        // Return success message
        return $"{amount} deposited successfully !Thank for visistng Bank of America!!";
    }

    // Method to withdraw money from the account
    public string Withdraw(decimal amount)
    {
        // Check for invalid withdrawal amount
        if (amount <= 0) return $"you cannot Withdraw Rs.{amount}";

        // Check if there is enough balance for withdrawal
        if (amount > Balance) return "your account doesnt have sufficiant money";

        // Deduct amount from balance
        Balance = Balance - amount;

        // Return success message
        return $"you are succesfuly withdraw Rs.{amount} and your balance is {Balance}";
    }
}
