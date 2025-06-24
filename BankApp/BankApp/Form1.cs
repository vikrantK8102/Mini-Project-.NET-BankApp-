// Namespace containing the bank application forms
namespace BankApp
{
    // Partial class for Form1 (Windows Form)
    public partial class Form1 : Form
    {
        // List to store all created bank accounts
        List<BankAccount> Bankaccounts = new List<BankAccount>();

        // Constructor initializing the form components
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for text change in textbox1 (not implemented)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // Event handler for label2 click (not implemented)
        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Event handler for cell click in DataGridView (not implemented)
        private void BankAccountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Event handler for Create Account button click
        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            // Prevent adding account if owner textbox is empty
            if (string.IsNullOrEmpty(ownertxt.Text))
            {
                return;
            }

            // If interest rate > 0, create savings account
            if (InterestRateNum.Value > 0)
            {
                Bankaccounts.Add(new
                    SavingsAccount(ownertxt.Text, InterestRateNum.Value));
            }
            else
            {
                // Create a regular bank account
                BankAccount bankAcc = new BankAccount(ownertxt.Text);
                Bankaccounts.Add(bankAcc);
            }

            // Refresh the DataGridView and reset input fields
            RefreshGrid();
            ownertxt.Text = string.Empty;
            InterestRateNum.Value = 0;
        }

        // Method to refresh the DataGridView display
        public void RefreshGrid()
        {
            // Clear existing data source
            BankAccountGrid.DataSource = null;
            // Bind the updated list to the DataGridView
            BankAccountGrid.DataSource = Bankaccounts;
        }

        // Event handler for label3 click (not implemented)
        private void label3_Click(object sender, EventArgs e)
        {
        }

        // Event handler for Amount numeric up-down value change (not implemented)
        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {
        }

        // Event handler for Deposit button click
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            // Ensure one row is selected for deposit
            if (BankAccountGrid.SelectedRows.Count == 1)
            {
                // Get the selected bank account
                BankAccount selectedBankaccount = BankAccountGrid.SelectedRows
                    [0].DataBoundItem as BankAccount;

                // Perform deposit and show message
                string message = selectedBankaccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        // Event handler for Withdraw button click
        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            // Ensure one row is selected for withdrawal
            if (BankAccountGrid.SelectedRows.Count == 1)
            {
                // Get the selected bank account
                BankAccount selectedBankAcc = BankAccountGrid.SelectedRows
                    [0].DataBoundItem as BankAccount;

                // Perform withdrawal and show message
                string message = selectedBankAcc.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
