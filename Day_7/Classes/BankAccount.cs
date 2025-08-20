using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Classes
{
    internal class BankAccount
    {
        private static string BankName="State Bank";
        private int accountNumber;
        private string accountHolderName;
        private double balance=0;
        private string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }
        private double Balance
        {
            get { return balance; }
            set
            {
                if (balance <= 0)
                {
                    Console.WriteLine("Insufficient Balance.");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public BankAccount(int accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            this. accountHolderName = accountHolderName;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New Balance: {balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }
        public void GetBalance()
        {
                Console.WriteLine($"Current Balance: {balance}");
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Bank Name: {BankName}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder Name: {accountHolderName}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
