using lesson5task1;
namespace Task1
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                ClassTown town1 = new();
                town1.PrintInfo();
                town1.Name = "Stryi";
                town1.Country = "Ukraine";
                town1.CountOfSityzen = 10000000;
                town1.PostCode = 82400;
                town1.District = "SichStrilciv";
                town1.PrintInfo();

                town1.SetData();
                town1.PrintInfo();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

