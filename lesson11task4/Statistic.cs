using System;
using System.IO;

namespace lesson11task4
{
    public class Statistic
    {
        public void Start(string? path)
        {
            StreamReader sr = null;
            StreamWriter positive = null;
            StreamWriter negative = null;
            StreamWriter twoDigit = null;
            StreamWriter fiveDigit = null;
            
            int positiveCount = 0;
            int negativeCount = 0;
            int twoDigitCount = 0;
            int fiveDigitCount = 0;
            
            try
            {
                if (string.IsNullOrEmpty(path) || !File.Exists(path))
                {
                    Console.WriteLine("File was not found.");
                    return;
                }
                sr = new StreamReader(path);
                positive = new StreamWriter("resultPositive.txt", false);
                negative = new StreamWriter("resultNegative.txt", false);
                twoDigit = new StreamWriter("resultTwoDigit.txt", false);
                fiveDigit = new StreamWriter("resultFiveDigit.txt", false);

                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string?[] numbers = line.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var num in numbers)
                    {
                        int temp = Convert.ToInt32(num);
                        if (temp >= 0)
                        {
                            positive.Write(num + " ");
                            positiveCount++;
                        }

                        if (temp < 0)
                        {
                            negative.Write(num + " ");
                            negativeCount++;
                        }

                        if (Math.Abs(temp) > 9 && Math.Abs(temp) < 100)
                        {
                            twoDigit.Write(num + " ");
                            twoDigitCount++;
                        }

                        if (Math.Abs(temp) > 9999 && Math.Abs(temp) < 100000)
                        {
                            fiveDigit.Write(num + " ");
                            fiveDigitCount++;
                        }
                    }
                }
                Console.WriteLine($"Result: {positiveCount} positive numbers were copied to resultPositive.txt");
                Console.WriteLine($"Result: {negativeCount} negative numbers were copied to resultNegative.txt");
                Console.WriteLine($"Result: {twoDigitCount} two digit numbers were copied to resultTwoDigit.txt");
                Console.WriteLine($"Result: {fiveDigitCount} five digit numbers were copied to resultFiveDigit.txt");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr?.Close();
                positive?.Close();
                negative?.Close();
                twoDigit?.Close();
                fiveDigit?.Close();
            }
        }
        
        public static void Generate(string path, int count)
        {
            Random rand = new Random();
            StreamWriter sw = new StreamWriter(path);
            {
                for (int i = 0; i < count; i++)
                {
                    int number = rand.Next(-100000, 100001);
                    sw.Write(number + " ");
                    if (i % 10 == 0 && i > 0) sw.WriteLine();
                }
            }
            Console.WriteLine($"Файл {path} успішно створено з {count} числами.");
        }
    }
}