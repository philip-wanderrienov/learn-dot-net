using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating one bank account
            var account = new BankAccount("Philip", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(200, DateTime.Now, "Phils Withdrawal");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(100, DateTime.Now, "Phils Deposit");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(-500, DateTime.Now, "Depositing minus balance");
            Console.WriteLine(account.Balance);
        }
    }
}
