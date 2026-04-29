using lesson17task1;

try
{
    CreditCard card = new CreditCard("Rick Sanchez", 137, "10/30", 1234, 1000, 500);
    
    card.AccountDeposit += (msg) => Console.WriteLine($"💰 {msg}");
    
    void LogToConsole(string message) 
    {
        Console.WriteLine($"[LOG]: {message}");
    }
    card.AccountDeposit += LogToConsole;
    
    card.AccountWithdrawal += (msg) => {
        if (msg.Contains("failed")) Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"💸 {msg}");
        Console.ResetColor();
    };
    card.AccountWithdrawal += LogToConsole;
    
    card.AccountBorrowing += (msg) => {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"🚨 {msg}");
        Console.ResetColor();
    };
    card.AccountBorrowing += LogToConsole;
    
    card.AccountBalanceExhausted += (msg) => Console.WriteLine($"ℹ️ {msg}");
    card.AccountChangePin += (msg) => Console.WriteLine($"ℹ️ {msg}");

    // ТЕСТУЄМО ЛОГІКУ
    card.Deposit(200);      // Баланс 700
    Console.WriteLine($"Total amount {card.Amount}");
    
    card.Withdrawal(700);   // Баланс 0 -> Викличе Exhausted
    card.Withdrawal(100);   // Баланс -100 -> Викличе Borrowing (овердрафт)
    card.ChangePin(99);     // Помилка PIN
    card.AccountDeposit -= LogToConsole; // Відміна підписки LOG
    card.Deposit(1200);     // Виклик без LOG
}
catch (Exception ex){ Console.WriteLine(ex.Message);}