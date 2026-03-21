namespace Task4
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                const ushort len = 10;
                int[] arr = new int[len];
                Random r = new();
                for (ushort i = 0; i < len; ++i)
                {
                   arr[i] = r.Next(0, 5);
                   Console.Write("{0, 4}", arr[i]);
                }

                Console.WriteLine();

                ushort count = 0;

                if (arr[0] != 0) Console.Write("{0, 4}", arr[0]);

                for (ushort i = 0; i < len; ++i)
                {
                    
                    if (arr[i] != 0 && i != 0)
                    {
                        arr[i - 1] = arr[i];
                        ++count;
                        Console.Write("{0, 4}", arr[i]);
                        arr[i] = 0;
                    }
                }

                if (arr[0] != 0) ++count;

                for (ushort i = count; i < len; ++i) Console.Write("{0, 4}", -1);

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
