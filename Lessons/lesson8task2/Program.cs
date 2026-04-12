using lesson8task2;
namespace BankAccaunt
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Bank newUser = new Bank();
                newUser.BankID = 1;
                newUser.Name = "Rostik";
                newUser.Balans = 2453;
                newUser.Info();

                Console.WriteLine("Додамо до балансу відємне значення -123");
                newUser.Deposit(-123);
                newUser.Info();
                Console.WriteLine("Додамо до балансу 3000");
                newUser.Deposit(3000);
                newUser.Info();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

