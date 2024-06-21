using System;

public class Logger
{
    private static Logger instance;
    
    private Logger() { }
    
    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
    
    public void LogTransaction(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}
using System;

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Logger.Instance.LogTransaction($"Deposit of {amount} to account {AccountNumber}. New balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            throw new InvalidOperationException("Withdrawal amount exceeds current balance.");
        }

        Balance -= amount;
        Logger.Instance.LogTransaction($"Withdrawal of {amount} from account {AccountNumber}. New balance: {Balance}");
    }
}
using System;

public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount("1234567890", 1000.0);

        account.Deposit(500.0);
        Console.WriteLine($"Current balance after deposit: {account.Balance}");

        try
        {
            account.Withdraw(200.0);
            Console.WriteLine($"Current balance after withdrawal: {account.Balance}");

            account.Withdraw(2000.0);
            Console.WriteLine($"Current balance after withdrawal: {account.Balance}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
