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
                Console.WriteLine("Enter 6 numbers:");
                uint sum = 0;
                uint dob = 1;
                uint max = 0;
                uint min = 999999;
                
                for (uint i = 0; i < 6; ++i)
                {
                    string? str = Console.ReadLine();
                    uint num = Convert.ToUInt32(str);

                    sum += num;
                    dob *= num;

                    if (max < num) max = num;
                    if (min > num) min = num;
                }

                Console.WriteLine($"Sum = {sum}; Dobutok = {dob}; Max = {max}; Min = {min} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

