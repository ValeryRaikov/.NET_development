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

        public override String Deposit(decimal amount)
        {
            if (amount <= 0)
                return $"Amount cannot be negative number: #{amount}!";
            if (amount > 20000)
                return "AML Deposit limit reached!";

            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;

            return "Deposit completed successfully!";
        }
    }
}
