namespace Task1
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                const ushort len = 20;
                int[] arr = new int[len];
                Random r = new();
                ushort countEven = 0;
                ushort countOdd = 0;
                ushort countUniq = 0;

                for (ushort i = 0; i < len; ++i)
                {
                    arr[i] = r.Next(1, 20);
                    if (arr[i] % 2 == 0) countEven++;
                    else countOdd++;   
                    Console.Write(arr[i] + " ");
                }

                Array.Sort(arr);

                for (ushort i = 0; i < len; ++i)
                {
                    bool isUniq = true;
                    if (i > 0 && arr[i] == arr[i - 1]) isUniq = false;
                    if (i < len - 1 && arr[i] == arr[i + 1]) isUniq = false;
                    if (isUniq) countUniq++;
                }
                

                Console.WriteLine($"\nК-сть парних чисел: {countEven} \nК-сть непарних: {countOdd}\n" +
                    $"К-сть унікальних чисел: {countUniq}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

