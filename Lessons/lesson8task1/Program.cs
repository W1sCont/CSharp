using lesson8task1;
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

                Console.WriteLine("\nlesson 8 taks 1\n");
                ClassEmployee emp1 = new("Олександр Коваленко");
                ClassEmployee emp2 = new("Марія Петренко");
                ClassEmployee emp3 = new("Іван Сірко");

                Console.WriteLine("Демонстрація фіксованої ставки");
                var res1 = emp1.CalculateSalary(15000);
                ClassEmployee.PrintInfo(emp1.FullName, res1);

                Console.WriteLine("Демонстрація погодинної оплати (наприклад, 200 грн/год, відпрацьовано 160 год)");
                var res2 = emp2.CalculateSalary(200, 160);
                ClassEmployee.PrintInfo(emp2.FullName, res2);

                Console.WriteLine("Демонстрація премії (ставка 12000 + 25% премії)");
                var res3 = emp3.CalculateSalary(12000, 25.0);
                ClassEmployee.PrintInfo(emp3.FullName, res3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
