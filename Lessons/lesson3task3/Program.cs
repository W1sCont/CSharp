namespace Task3
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                const ushort len = 5;
                int[,] arr = new int[len, len];
                Random r = new();
                for (ushort i = 0; i < len; ++i)
                {
                    for (ushort j = 0; j < len; ++j)
                    {
                        arr[i, j] = r.Next(-10, 40);
                        Console.Write("{0,4}", arr[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();


                for (ushort j = 0; j < len; ++j)
                {
                    int sum = 0;
                    for (ushort i = 0; i < len; ++i)
                    {
                        // Console.Write(arr[i, j] + "     ");
                        if (arr[i, j] < 0)
                        {
                            sum = 0;
                            break;
                        }
                        sum += arr[i, j];
                    }
                    if (sum > 0) Console.Write("{0,4}", sum);
                    else Console.Write("{0,4}", " ");
                }
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
