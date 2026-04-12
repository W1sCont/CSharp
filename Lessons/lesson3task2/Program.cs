namespace Task2
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                const uint len = 20;
                int[] arr = new int[len];
                Random r = new();
                int sum = 0;

                for (uint i = 0; i < len; ++i)
                {
                    arr[i] = r.Next(-30, 10);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                foreach (int i in arr)
                {
                    if (i > 0) break;
                    Console.Write(i + " ");
                    sum += i;
                }

                Console.WriteLine($"\nСума до першого позитивного числа: {sum}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
