using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            if (InterestRateNum.Value > 0)
            {
                SavingsAccount savingsAccount = new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value);
                BankAccounts.Add(savingsAccount);
            }
            else
            {
                BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
                BankAccounts.Add(bankAccount);
            }

            RefreshGrid();

            OwnerTxt.Text = string.Empty;
            InterestRateNum.Value = 0;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                String message = selectedBankAccount.Deposit(AmountNum.Value);

                RefreshGrid();

                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void WithdrwaBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                String message = selectedBankAccount.Withdraw(AmountNum.Value);

                RefreshGrid();

                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
