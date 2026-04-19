using lesson14task2;

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
                ArrayInteger arr = new ArrayInteger(23);
                IMath obj = arr;
                Client cl = new Client(obj);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}