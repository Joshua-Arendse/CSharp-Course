using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSimulator
{
    internal class BankAccount
    {
        public string AccountHolder {  get; set; }
        public string AccountNumber { get; set; }
        private decimal Balance {  get; set; }// Encapsulation: private to control access

        public BankAccount(string accountHolder, string accountNumber, decimal balance) 
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit {amount:C}. New Balance: {Balance:C}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New Balance: {Balance:C}");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public void ViewBalance()
        {
            Console.WriteLine($"Current Balance: {Balance:C}");
        }
    }
}
