using lesson19task3;

namespace Program_19_3
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Task3 t1 = new Task3();
                TextDataProcessing tdp = t1.VowelCount;
                tdp += t1.ConsonantCount;
                tdp += t1.LenghtCount;
                string? str = "Hello world!";
                Console.WriteLine(str);
                t1.Client(tdp, str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}