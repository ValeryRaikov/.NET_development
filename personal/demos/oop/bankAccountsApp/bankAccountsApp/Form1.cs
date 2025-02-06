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
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAcc = new BankAccount();
            bankAcc.Owner = "Valery Raikov";
            bankAcc.AccountNumber = Guid.NewGuid();
            bankAcc.Balance = 7000;

            BankAccount bankAcc2 = new BankAccount();
            bankAcc2.Owner = "Meggie Philipova";
            bankAcc2.AccountNumber = Guid.NewGuid();
            bankAcc2.Balance = 2500;

            BankAccount bankAcc3 = new BankAccount();
            bankAcc3.Owner = "Maria Mitova";
            bankAcc3.AccountNumber = Guid.NewGuid();
            bankAcc3.Balance = 30000;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAcc);
            bankAccounts.Add(bankAcc2);
            bankAccounts.Add(bankAcc3);

            BankAccountsGrid.DataSource = bankAccounts;
        }

    }
}
