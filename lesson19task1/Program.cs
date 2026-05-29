using lesson19task1;

namespace Program_19_1
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            const string CatHappy = "     /\\_/\\  \r\n    ( ^.^ ) \r\n     > ^ <";
            const string CatNead = "     /\\_/\\  \r\n    ( 0.0 ) \r\n      Мяу? Мяу!";
            const string CatSick = "     /\\_/\\  \r\n    ( x.x ) \r\n    ~ (   )~";
            const string CatDied = "     /\\_/\\  \r\n    ( *.* ) \r\n       †";

            try
            {
                Console.WriteLine("Привіт мене звати Мурчик!\nДоглядай за мною і я буду слухняний");
                Console.WriteLine(CatHappy);

                int timePassed = 0;
                const int updateInterval = 4000;
                const int loopDelay = 100;

                Tamagochi tamagochi = new Tamagochi();

                tamagochi.BecameHungry += (msg) => { Render(tamagochi, CatNead, msg); };
                tamagochi.BecameTired += (msg) => { Render(tamagochi, CatNead, msg); };
                tamagochi.Sick += (msg) => { Render(tamagochi, CatSick, msg); };
                tamagochi.Happy += (msg) => { Render(tamagochi, CatHappy, msg); };
                tamagochi.Died += (msg) => { Render(tamagochi, CatDied, msg); };

                while (tamagochi.isAlive)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);

                        switch (key.Key)
                        {
                            case ConsoleKey.D1: 
                                tamagochi.Feed();
                                timePassed = 0; 
                                break;
                            case ConsoleKey.D2: 
                                tamagochi.PutToBed();
                                timePassed = 0;
                                break;
                            case ConsoleKey.D3:
                                if (tamagochi.isSick)
                                {
                                    tamagochi.Cure();
                                    timePassed = 0;
                                }
                                break;
                        }
                    }

                    if (timePassed >= updateInterval)
                    {
                        tamagochi.NextTurn();
                        timePassed = 0;       
                    }
                    Thread.Sleep(loopDelay);
                    timePassed += loopDelay;
                }


                Console.WriteLine("\nГра завершена.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Render(Tamagochi tamagochi, string catArt, string? msg)
        {
            Console.Clear();
            Console.WriteLine(catArt);

            if (!string.IsNullOrEmpty(msg))
            {
                Console.WriteLine($"\n{msg}");
            }
            Console.WriteLine($"   [Голод: {tamagochi.Hungry}/100 | Втома: {tamagochi.Tired}/100]");
            if (tamagochi.isSick)
            {
                Console.WriteLine("1 - Погодувати, 2 - Покласти спати, 3 - Вилікувати");
            }
            else
            {
                Console.WriteLine("1 - Погодувати, 2 - Покласти спати");
            }
        }
    }
}