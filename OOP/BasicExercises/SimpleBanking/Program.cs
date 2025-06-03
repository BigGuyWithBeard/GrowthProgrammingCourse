
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Simple Banking System!");

        bool isExiting = false;
        BankAccount account = new BankAccount();
        do
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine($"Your current balance is: {account.Balance}");
                    break;
                case "2":
                    Console.WriteLine("Enter the amount to deposit:");
                    string depositAmount = Console.ReadLine();
                    account.Deposit(double.Parse(depositAmount));
                    Console.WriteLine($"You have deposited {depositAmount}. Your new balance is: {account.Balance}");
                    // if only it was that simple in real life!
                    break;
                case "3":

                    Console.WriteLine("Enter the amount to withdraw:");
                    string withdrawAmount = Console.ReadLine();

                    if (account.Balance < double.Parse(withdrawAmount))
                    {
                        Console.WriteLine("Insufficient funds. Please deposit money before withdrawing.");
                        break;
                    }
                    else
                    {
                        account.Withdraw(double.Parse(withdrawAmount));
                        Console.WriteLine($"You have withdrawn {withdrawAmount}. Your new balance is: {account.Balance}");
                    }

                    break;
                case "4":
                    isExiting = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (!isExiting);








    }
}