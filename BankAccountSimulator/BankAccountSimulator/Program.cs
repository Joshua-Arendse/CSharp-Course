namespace BankAccountSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank!");
            Console.Write("Enter Account Holder Name: ");
            string accountHolder = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            // Create a new bank account
            BankAccount account = new BankAccount(accountHolder, accountNumber, balance);

            while (true)
            {
                Console.WriteLine("\nBank Menu:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case "2":
                        Console.Write("Enter amount to withdraw: ");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;

                    case "3":
                        account.ViewBalance();
                        break;

                    case "4":
                        Console.WriteLine("Thank you for using the bank. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
