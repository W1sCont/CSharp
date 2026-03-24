using lesson5task2;
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
                var Michael = new ClassEmployee();
                Michael.Info();

                Michael.FullName = "Грушевський Михайло Сергійович";
                Michael.DateOfBirthday = "29 вересня 1866";
                Michael.PhoneNumber = "1234567890";
                Michael.Email = "michael_freedom@ukraine.com";
                Michael.Position = "Український історик, громадський і політичний діяч";
                Michael.Duties = "автор понад 2000 наукових праць";

                Michael.Info();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

