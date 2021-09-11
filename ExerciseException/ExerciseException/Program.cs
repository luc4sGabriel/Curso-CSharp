using System;
using System.Globalization;
using ExerciseException.Entities;
using ExerciseException.Exceptions;


namespace ExerciseException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine());

            Account acc = new Account(number,holder,balance,limit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine());
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}
