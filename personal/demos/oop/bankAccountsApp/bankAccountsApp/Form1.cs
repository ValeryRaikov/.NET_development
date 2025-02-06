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

            BankAccount bankAcc = new BankAccount("Valery Raikov");
            BankAccount bankAcc2 = new BankAccount("Meggie Philipova");
            BankAccount bankAcc3 = new BankAccount("Maria Mitova");

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAcc);
            bankAccounts.Add(bankAcc2);
            bankAccounts.Add(bankAcc3);

            BankAccountsGrid.DataSource = bankAccounts;
        }

    }
}
