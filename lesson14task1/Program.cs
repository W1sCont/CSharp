using lesson14task1;

namespace MyNamespace
{
    public class MyClass
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                ArrayInteger arr = new ArrayInteger(10);
                ICalc ic = arr;
                Client client = new Client(ic);
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}

