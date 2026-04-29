namespace lesson17task1;

public delegate void CardNotify(string message);

public class CreditCard
{
    private int _pin;
    
    public event CardNotify? AccountDeposit;
    public event CardNotify? AccountWithdrawal;
    public event CardNotify? AccountBorrowing;
    public event CardNotify? AccountBalanceExhausted;
    public event CardNotify? AccountChangePin;
    
    public string? FullName { get; set; }
    public int CardNumber { get; set; }
    public string? ValidThru { get; set; }

    public int PIN
    {
        get => _pin;
        set
        {
            if (value >= 1000 && value < 10000) _pin = value;
            else Console.WriteLine("Invalid PIN");
        }
    }

    public int CreditLimit { get; set; }

    public int Amount { get; set; }
    

    public CreditCard(string? fullName, int cardNumber, string? validThru, int pin, int creditLimit, int amount)
    {
        FullName = fullName;
        CardNumber = cardNumber;
        ValidThru = validThru;
        PIN = pin;
        CreditLimit = creditLimit;
        Amount = amount;
    }
    
    public CreditCard()
        : this(null, 0, null, 0, 0,0) {}
    
    // Deposit
    public void Deposit(int num)
    {
        Amount += num;
        AccountDeposit?.Invoke($"Deposit {num} ");
    }
    // Withdrawal
    public void Withdrawal(int num)
    {
        if (Amount + CreditLimit >= num)
        {
            Amount -= num;
            AccountWithdrawal?.Invoke("Withdrawal successful");
            Check();
        }
        else
        {
            Console.WriteLine("Balance exceeded");
            AccountWithdrawal?.Invoke("Withdrawal failed");
        }
    }
    // Change PIN
    public void ChangePin(int num)
    {
        if (num > 1000 && num < 10000)
        {
            PIN = num;
            AccountChangePin?.Invoke("PIN updated successfully!");
        }
        else
        {
            Console.WriteLine("Invalid PIN");
            AccountChangePin?.Invoke("PIN must be 4 digits long");
        }
    }

    // Personal balance exhausted || Entering the overdraft
    private void Check()
    {
        if (Amount == 0) AccountBalanceExhausted?.Invoke("Personal balance exhausted");
        if (Amount < 0) AccountBorrowing?.Invoke($"Alert. Entering the overdraft {Math.Abs(Amount)}");
    }
}