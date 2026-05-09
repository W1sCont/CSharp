using lesson19task2;

namespace Program_19_2
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Methods m1 = new Methods();
                Action n1 = new Action(m1.CurrentTime);
                Methods.Client(n1);
                Methods.Client(m1.CurrentDate);
                Methods.Client(() => Console.WriteLine($"Current day of week: {DateTime.Now.DayOfWeek}"));
                Methods.Client(Methods.DayOfWeek);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}