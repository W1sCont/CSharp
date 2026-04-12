using lesson7task1;

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
        Console.WriteLine($"data3 day of week: {date3.DayOfWeek}");
        Console.WriteLine($"Різниця між data2 i data3 {date2.DayDifference(date3)}");

        Console.WriteLine("\nЗавдання 7_1\n");
        Console.WriteLine($"Чи рівні між собою data2 та data3: {date2 == date3}");
        Console.WriteLine($"Чи не рівні між собою data2 та data3: {date2 != date3}");
        Console.WriteLine($"Чи data2 > data3: {date2 > date3}");
        Console.WriteLine($"Чи data2 < data3: {date2 < date3}");
        Console.WriteLine();
        Console.WriteLine($"Додамо data2 + data3: {date2 += date3}");
        Console.WriteLine(date2.DayOfWeek);
        Console.WriteLine($"Віднімемо data2 + data3: {date2 -= date3}");
        Console.WriteLine(date2.DayOfWeek);
        //
        date2.Year = 234;
        Console.WriteLine("Змінили у date2 рік на 234");
        date2.Print();

        date2.Month = 1;
        Console.WriteLine("Змінили у date2 місяць на січень");
        date2.Print();

        date2.Day = 23;
        Console.WriteLine("Змінили у date2 день на 23");
        date2.Print();
    }
}