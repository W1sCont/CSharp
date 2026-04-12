using lesson5task3;

class MainClass
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Date date1 = new();
        Date date2 = new(21, 04, 1995);
        Date date3 = new();
        date3 = date2.Rescheduling(234);

        Console.WriteLine("data1");
        date1.Print();
        Console.WriteLine("data2");
        date2.Print();
        Console.WriteLine("data3");
        date3.Print();

        Console.WriteLine($"Різниця між data2 i data3 {date2.DayDifference(date3)}");


    }
}