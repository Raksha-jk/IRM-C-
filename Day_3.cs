using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance=10000;
            int option,deposit,withdrawal;
            int withdrawalLimit = 0;
            int passLimit = 0;
            int password = 1234;
            Console.WriteLine("Enter your password to access the ATM:");
            int enteredPassword = Convert.ToInt32(Console.ReadLine());
            if (enteredPassword != password)
            {
                Console.WriteLine("Incorrect password. Exiting the program.");
                return;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("1. Check Balance\n2. Deposit Money\n3. Withdraw Money\n4. Exit");
                    Console.Write("Please select an option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Your current balance is " + balance);
                            break;
                        case 2:
                            while (true)
                            {
                                Console.Write("Enter your deposit amount:");
                                deposit = Convert.ToInt32(Console.ReadLine());
                                if (deposit <= 0)
                                {
                                    Console.WriteLine("Please try again.");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            balance += deposit;
                            Console.WriteLine("Your new balance is: " + balance);
                            break;
                        case 3:
                            if (withdrawalLimit < 3)
                            {
                                while (true)
                                {
                                    Console.Write("Enter your withdrawal amount: ");
                                    withdrawal = Convert.ToInt32(Console.ReadLine());
                                    if (withdrawal < 100)
                                    {
                                        Console.WriteLine("Minimum withdrawal amount is 100. Please try again.");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                if (withdrawal > balance)
                                {
                                    Console.WriteLine("Insufficient funds. Your current balance is: " + balance);
                                }
                                else
                                {
                                    balance -= withdrawal;
                                    Console.WriteLine("Your new balance is: " + balance);
                                }
                                withdrawalLimit++;
                            }
                            else
                            {
                                Console.WriteLine("You have reached the withdrawal limit.");
                                break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Exiting the program. Thank you!");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;

                    }
                }
            }

        }
    }
}