namespace Task6
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.Write("Введіть N (рядки): ");
                string? str = Console.ReadLine();
                ushort N = Convert.ToUInt16(str);
                Console.Write("Введіть M (стовпці): ");
                str = Console.ReadLine();
                ushort M = Convert.ToUInt16(str);
                Random r = new();
                int[,] arr = new int[N, M];

                for (ushort i = 0; i < N; ++i)
                {
                    for (ushort j = 0; j < M; ++j)
                    {
                        arr[i, j] = r.Next(0, 100);
                        Console.Write("{0, 4}",arr[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.Write("Введіть к-ть зсувів: ");
                str = Console.ReadLine();
                ushort numOfRow = Convert.ToUInt16(str);
                Console.WriteLine("Напрямок (1 - вправо, 2 - вліво): ");
                char key = Console.ReadKey(true).KeyChar;

                if (numOfRow > M) numOfRow %= M;
                int[] temp = new int[M];

                if (key == '1')
                {
                    for (ushort i = 0; i < N; ++i)
                    {
                        for (ushort j = 0; j < M; ++j)
                        {
                            temp[(j + numOfRow) % M] = arr[i, j];
                        }

                        for (ushort j = 0; j < M; ++j)
                        {
                            arr[i, j] = temp[j];
                        }
                    }

                    for (ushort i = 0; i < N; ++i)
                    {
                        for (ushort j = 0; j < M; ++j)
                        {
                            Console.Write("{0, 4}", arr[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                else if (key == '2')
                {
                    for (ushort i = 0; i < N; ++i)
                    {
                        for (ushort j = 0; j < M; ++j)
                        {
                            temp[(j - numOfRow + M) % M] = arr[i, j];
                        }

                        for (ushort j = 0; j < M; ++j)
                        {
                            arr[i, j] = temp[j];
                        }
                    }

                    for (ushort i = 0; i < N; ++i)
                    {
                        for (ushort j = 0; j < M; ++j)
                        {
                            Console.Write("{0, 4}", arr[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                else Console.WriteLine("Не вірний напрямок. Помилка");          
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
