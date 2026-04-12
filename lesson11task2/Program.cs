using lesson11task2;

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
                Console.WriteLine("Enter path to file: ");
                string? filename = Console.ReadLine();
                Console.WriteLine("Enter path to file with words: ");
                string? word = Console.ReadLine();
                Moderator start = new();
                start.Mod(filename, word);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}