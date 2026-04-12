using lesson11task3;

namespace Program_11_3
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
                
                Run start = new();
                start.Start(filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}