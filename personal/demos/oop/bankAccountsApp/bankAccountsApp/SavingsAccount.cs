using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountsApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(String owner, decimal interestRate) : base(owner + "(" + interestRate + "%)")
        {
            InterestRate = interestRate;
        }
    }
}
