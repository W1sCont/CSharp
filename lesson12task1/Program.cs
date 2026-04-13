using lesson12task1;

namespace Lesson_12_1
{
    class MyClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            try
            {
                Passport hl = new Passport(123456, "Hannibal", "Lecter", "Romanovych", "21 oct 1981",
                    "Male", "22 jul 1993", "21 jul 2093");
                hl.Info();
                Console.WriteLine();
                ForeignPassport fpgl = new ForeignPassport("Ukraine", 654321, "Hannibal", "Lecter", "Romanovych",
                    "21 oct 1981", "Male", "23 may 2025", "23 may 2030");
                fpgl.Info();
                Console.WriteLine();
                fpgl.SetVisa("Poland", "14 apr 2020", "14 apr 2030");
                fpgl.SetVisa("USA", "18 sep 2024", "18 sep 2026");
                fpgl.InfoVisa();
                Console.WriteLine(fpgl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

