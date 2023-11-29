using System;

public class BankAccount
{
    private string accountNumber;
    private string accountHolder;
    private decimal balance;

    public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public string AccountHolder
    {
        get { return accountHolder; }
    }

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        // Create a new bank account
        BankAccount account = new BankAccount("123456789", "Earnest Muyunda", 1500.00m);

        // Deposit and withdraw
        account.Deposit(1000.00m);

        if (account.Withdraw(200.00m))
        {
            Console.WriteLine("Withdrawal successful. New balance: " + account.Balance);
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}