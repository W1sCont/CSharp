using System;
using System.Text;

namespace CoD1
{
    public static class Kata
    {
        public static string Solution(string str)
        {
            StringBuilder s = new StringBuilder(str);
            char temp = ' ';
            int len = str.Length - 1;
            for (ushort i = 0; i < str.Length / 2; ++i)
            {
                temp = s[i];
                s[i] = s[len];
                s[len] = temp;
                --len;
            }
            return s.ToString();
            throw new NotImplementedException("TODO: Kata.Solution(string) => string");
        }

        static void Main()
        {
            Console.WriteLine(Solution("world"));
        }

    }
}
