namespace lesson19task1;

public delegate void TamagochiDelegate(string? messsage);
public class Tamagochi
{
    public int Hungry { get; private set; }
    public int Tired { get; private set; }
    
    private int _strikes = 0;
    private bool _isHungry = false;
    private bool _isTired = false;
    public bool isSick { get; private set; } = false;
    public bool isAlive { get; private set; } = true; 

    private readonly Random _random = new Random();

    public event TamagochiDelegate? BecameHungry;
    public event TamagochiDelegate? BecameTired;
    public event TamagochiDelegate? Sick;
    public event TamagochiDelegate? Happy;
    public event TamagochiDelegate? Died;

    public Tamagochi()
    {
        Hungry = 0;
        Tired = 0;
    }
    public void NextTurn()
    {
        if (_isHungry || _isTired) _strikes++;
        GenerateNeed();
        CheckStatus();
    }

    private void GenerateNeed()
    {
        int result = _random.Next(0, 2);
        switch (result)
        {
            case 0:
                Hungry += 35;
                if (Hungry > 100) Hungry = 99;
                break;
            case 1:
                Tired += 35;
                if (Tired > 100) Tired = 99;
                break;
        }
    }

    public void Feed()
    {
        if (Hungry > 50) Hungry -= 50;
        _isHungry = false;
        if (_strikes > 0) { _strikes--; }
        Happy?.Invoke("Я більше не голодний =)");
    }

    public void PutToBed()
    {
        if (Tired > 50) Tired -= 50;
        _isTired = false;
        if (_strikes > 0) { _strikes--; }
        Happy?.Invoke("Я гарно виспався");
    }

    public void Cure()
    {
        if(!isSick) return;

        _strikes = 0;
        if(Hungry > 50) Hungry = 0;
        if(Tired > 50) Tired = 0;
        isSick = false;
        Happy?.Invoke("Я почуваю себе чудово =)");
    }

    private void CheckStatus()
    {
        if (Hungry >= 100 || Tired >= 100)
        {
            _strikes++;
        }

        if (Tired >= 60 && !_isTired)
        {
            _isTired = true;
            BecameTired?.Invoke("Я хочу спатки...");
        }

        if (Hungry >= 60 && !_isHungry)
        {
            _isHungry = true;
            BecameHungry?.Invoke("Я дуже голодний!");
        }

        if (_strikes == 3)
        {
            isSick = true;
            Sick?.Invoke("Я дуже сильно захворів! Мені потрібні ліки!");
        }

        if(_strikes >= 4)
        {
            Died?.Invoke("Ти задовго ігнорував мене... Прощавай.");
            isAlive = false;
        }
    }
}