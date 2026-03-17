namespace CSharpApplication.DataTypes
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                uint len = 1;
                uint maxLen = 1;
                uint startInd = 1;
                uint bestStart = 1;
                uint prevNum = 0;

                Console.WriteLine("Введіть 15 чисел:\n");
                Console.WriteLine("Введіть 1 число: ");
                prevNum = Convert.ToUInt32(Console.ReadLine());

                for (uint i = 2; i <= 15; ++i)
                {
                    Console.WriteLine($"Введіть {i} число:");
                    string? str = Console.ReadLine();
                    uint num = Convert.ToUInt16(str);

                    if (i > 0)
                    {
                        if (num >= prevNum)
                        {
                            ++len;
                            if (len > maxLen)
                            {
                                maxLen = len;
                                bestStart = startInd;
                            }
                        }
                        else
                        {
                            len = 1;
                            startInd = i;
                        }

                    }
                    prevNum = num;
                }

                Console.WriteLine($"\nНайдовший ланцюжок довжиною {maxLen}");
                Console.WriteLine($"Початок ланцюжка з {bestStart} ");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

