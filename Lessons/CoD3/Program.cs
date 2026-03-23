using System;

namespace CoD2
{
    class MainClass
    {
        static void Main()
        {
            char GradeBook(uint a, uint b, uint c)
            {
                uint aver = (a + b + c) / 3;
                if (aver >= 90) return 'A';
                if (aver >= 80) return 'B';
                if (aver >= 70) return 'C';
                if (aver >= 60) return 'D';
                return 'F';
            }

            uint a = 72;
            uint b = 78;
            uint c = 82;

            Console.WriteLine(GradeBook(a, b, c));

        }
    }
}
