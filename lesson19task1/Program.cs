using lesson19task1;

namespace Program_11_2
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Tamagochi pet = new Tamagochi();
                
                pet.OnRequest += (msg) => 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЯ хочу: {msg.ToUpper()}!");
                    Console.ResetColor();
                };

                pet.OnCriticalState += (msg) => 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{msg}");
                    Console.ResetColor();
                };

                pet.StartLife();
            
                Console.WriteLine("\nГра завершена.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}