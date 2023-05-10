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
            var account = new BankAccount("Philip", 250000);
            Console.WriteLine($"Account {account.Number}was created for {account.Owner} with {account.Balance}.");
        }
    }
}
