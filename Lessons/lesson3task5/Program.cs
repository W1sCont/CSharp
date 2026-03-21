namespace Task5
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Введіть не парне число: ");
                string? str = Console.ReadLine();
                uint num = (Convert.ToUInt16(str));

                uint[,] arr = new uint[num, num];
                uint x = num / 2;
                uint y = num / 2;
                uint step = 1;
                uint curentNum = 1;

                arr[x, y] = curentNum;

                while (curentNum < num * num)
                {
                    for (int i = 0; i < step && curentNum < num * num; ++i) // up
                    {
                        arr[--x, y] = ++curentNum;
                    }

                    for (int i = 0; i < step && curentNum < num * num; ++i) // left
                    {
                        arr[x, --y] = ++curentNum;
                    }

                    ++step;

                    for (int i = 0; i < step && curentNum < num * num; ++i) // down
                    {
                        arr[++x, y] = ++curentNum;
                    }

                    for (int i = 0; i < step && curentNum < num * num; ++i) // right
                    {
                        arr[x, ++y] = ++curentNum;
                    }

                    ++step;
                }

                for (int i = 0; i < num; ++i)
                {
                    for (int j = 0; j < num; ++j)
                    {
                        Console.Write(string.Format("{0,3}", arr[i, j]));
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
