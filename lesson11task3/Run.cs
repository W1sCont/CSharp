using System;
using System.IO;

namespace lesson11task3
{ 
    public class Run
    {
        public void Start(string path)
        {
            StreamReader sr = null;
            StreamWriter sw = null;
            try
            {
                if (string.IsNullOrEmpty(path) || !File.Exists(path))
                {
                    Console.WriteLine("File was not found.");
                    return;
                }
                sr = new StreamReader(path);
                sw = new StreamWriter("result.txt", false);

                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string?[] words = line.Split(" ");
                    Array.Reverse(words);
                    string? result = string.Join(" ", words);
                    sw.WriteLine(result);
                }
                Console.WriteLine("Result in result.txt\n");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
                sw.Close();
            }
        }
    }
}

