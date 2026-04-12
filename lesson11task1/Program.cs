using lesson11task1;

namespace Program_11_1
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
                Console.WriteLine("Word to be replaced: ");
                string? word1 = Console.ReadLine();
                Console.WriteLine("Replace with: ");
                string? word2 = Console.ReadLine();
                FindWord start = new();
                start.Run(filename, word1, word2);
                start.Print("result.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

