using lesson13task3;
namespace MyNamespace
{
    class MyClass
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            try
            {
                President pr = new President("John", "Snow", 56, "Annual Profit Share");
                Security sr = new Security("Iron", "Man", 29, "Carabine");
                Manager mr = new Manager("Oleg", "Mangust", 28, "Sales");
                Engineer er = new Engineer("Karl", "Hofman", 30, "Python");
                Worker w;
                Console.WriteLine("President");
                w = pr;
                w.Print();
                Console.WriteLine("Security");
                w = sr;
                w.Print();
                Console.WriteLine("Manager");
                w = mr;
                w.Print();
                Console.WriteLine("Engineer");
                w = er;
                w.Print();
            }
            catch (Exception ex){ Console.WriteLine(ex.Message);}
        }
    }
    
}