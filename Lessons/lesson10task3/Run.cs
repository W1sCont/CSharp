using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lesson10task3
{
    internal class Run
    {
        private const string Vowels = "аеєиіїоуюяaeiouyАЕЄИІЇОУЮЯAEIOUY";
        private const string Consonants = "бвгґджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxzБВГҐДЖЗЙКЛМНПРСТФХЦЧШЩBCDFGHJKLMNPQRSTVWXZ";
        private const string SentencesEnds = ".!?";
        public void RunStatistics(string? path)
        {
            StreamReader sr = null;
            
            try
            {
                sr = new StreamReader(path);
                int sentenceCount = 0;
                int wordCount = 0;
                int upperCount = 0;
                int lowerCount = 0;
                int vowelCount = 0;
                int consonantCount = 0;

                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;

                    foreach (char c in line)
                    {
                        if (char.IsUpper(c)) upperCount++;
                        if (char.IsLower(c)) lowerCount++;

                        if (Vowels.Contains(c)) vowelCount++;
                        else if (Consonants.Contains(c)) consonantCount++;

                        if (SentencesEnds.Contains(c)) sentenceCount++;
                    }
                }
                DisplayStatistics(path, sentenceCount, upperCount, lowerCount, vowelCount, consonantCount, wordCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }
        private void DisplayStatistics(string path, int s, int up, int low, int v, int c, int w)
        {
            Console.WriteLine($"\n=== Статистика файлу:      {path} ===");
            Console.WriteLine($"• Кількість речень:          {s}");
            Console.WriteLine($"• Кількість слів:            {w}");
            Console.WriteLine($"• Великих літер:             {up}");
            Console.WriteLine($"• Маленьких літер:           {low}");
            Console.WriteLine($"• Голосних букв:             {v}");
            Console.WriteLine($"• Приголосних букв:          {c}");
            Console.WriteLine("==========================================\n");
        }
    }
}
