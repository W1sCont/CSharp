namespace lesson19task1;

public delegate void TamagochiDelegate(string? messsage);

public class Tamagochi
{
    public event TamagochiDelegate? OnRequest;
    public event TamagochiDelegate? OnCriticalState;
    
    private string[] requests = { "Погодувати", "Погуляти", "Укласти спати", "Полікувати", "Пограти" };
    private int lastRequestIndex = -1;
    private int ignoreCount = 0;
    private bool isSick = false;
    public bool IsAlive { get; private set; } = true;

    public void StartLife()
    {
        Random rand = new Random();
        while (IsAlive)
        {
            Console.Clear();
            DrawPet();
            int currentIndex;
            do
            {
                currentIndex = rand.Next(requests.Length);
            } while (currentIndex == lastRequestIndex);

            lastRequestIndex = currentIndex;
            string currentRequest = requests[currentIndex];
            OnRequest?.Invoke(currentRequest);
            Console.WriteLine("\nНатисніть 'Enter', щоб виконати, або почекайте (3 сек)...");

            if (!WaitForInput(3000))
            {
                ignoreCount++;
                HandleIgnoredRequest();
            }
            else
            {
                ignoreCount = 0;
                isSick = false;
                Console.WriteLine("Дякую! Мені стало краще.");
                Thread.Sleep(1000);
            }
        }
    }
    private bool WaitForInput(int timeoutMs)
    {
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalMilliseconds < timeoutMs)
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                return true;
            Thread.Sleep(100);
        }
        return false;
    }
    private void HandleIgnoredRequest()
    {
        if (ignoreCount >= 3 && !isSick)
        {
            isSick = true;
            OnCriticalState?.Invoke("Я захворів! Терміново полікуй мене!");
            Thread.Sleep(2000);
        }
        else if (isSick && ignoreCount >= 4)
        {
            IsAlive = false;
            OnCriticalState?.Invoke("Ваш Тамагочі помер від неуваги... 💀");
        }
    }
    private void DrawPet()
    {
        string face = isSick ? "  X   X  " : "  o   o  ";
        string mouth = isSick ? "    ~    " : "    v    ";
    
        Console.WriteLine("   .--.              .--.   ");
        Console.WriteLine("  : (\\ \". _......_ .\" /) :  ");
        Console.WriteLine("   '.    `        `    .'   ");
        Console.WriteLine($"    /  {face}      \\    ");
        Console.WriteLine($"   (   {mouth}       )   ");
        Console.WriteLine("    '._            _.'    ");
        Console.WriteLine("       '--......--'       ");
    }
}