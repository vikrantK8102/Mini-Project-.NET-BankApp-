// Namespace containing the bank application classes
namespace BankApp
{
    // Class representing a savings account, inheriting from BankAccount
    public class SavingsAccount : BankAccount
    {
        // Property to store the interest rate for the savings account
        public decimal InterestRate { get; set; }

        // Constructor initializing owner name (with interest rate in name) and setting interest rate
        public SavingsAccount(string owner, decimal interestR) : base(owner + "   (" + interestR + " %)")
        {
            InterestRate = interestR;
        }

        // Overridden method for depositing money with interest applied
        public override string Deposit(decimal amount)
        {
            // Check for invalid deposit amount
            if (amount <= 0) return $"you cannot deposit Rs.{amount}";

            // Check if deposit exceeds AML (Anti-Money Laundering) limit
            if (amount > 20000) return "AML desposit limit is reached.";

            // Calculate interest on the deposited amount
            decimal interestAmt = (InterestRate / 100) * amount;

            // Update balance by adding principal + interest
            Balance = amount + interestAmt;

            // Return success message
            return $"{amount} deposited successfully !Thank for visistng Bank of America!!";
        }
    }
}
