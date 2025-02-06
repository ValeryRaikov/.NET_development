using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccountsApp
{
    public class BankAccount
    {
        public String Owner { get; protected set; }
        public Guid AccountNumber { get; protected set; }
        public decimal Balance { get; protected set; }

        public BankAccount(String owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public virtual String Deposit(decimal amount)
        {
            if (amount <= 0)
                return $"Amount cannot be negative number: #{amount}!";
            if (amount > 20000)
                return "AML Deposit limit reached!";

            Balance += amount;

            return "Deposit completed successfully!";
        }

        public String Withdraw(decimal amount)
        {
            if (amount <= 0)
                return $"Amount cannot be negative number: #{amount}!";
            if (amount > 20000)
                return "AML Withdraw limit reached!";
            if (amount > Balance)
                return "Insufficient User balance!";

            Balance -= amount;

            return "Withdraw completed successfully!";
        }
    }
}
