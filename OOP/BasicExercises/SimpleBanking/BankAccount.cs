public class BankAccount
{


    public double Balance { get; private set; } = 0.0;


    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds for withdrawal.");
        }
        Balance -= amount;
    }
    
}