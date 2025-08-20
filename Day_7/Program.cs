using OOPS.Classes;
using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account_1= new BankAccount(123456, "John Doe");
            BankAccount account_2 = new BankAccount(654321, "Jane Smith");
            BankAccount account_3 = new BankAccount(111222, "Alice Johnson");
            account_1.Deposit(500);
            account_1.Withdraw(500);
            account_1.Withdraw(500);
            account_1.GetBalance();
            account_1.DisplayAccountDetails();
        }
    }
}
