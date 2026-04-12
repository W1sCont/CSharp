using System;
using System.IO;
namespace lesson11task1
{
    public class FindWord
    {
        public void Run(string? path, string? word1, string? word2)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path) || word1 == null || word2 == null)
            {
                Console.WriteLine("File was not found at this path or words are null.");
                return;
            }
            
            StreamReader? sr = null;
            StreamWriter? sw = null;
            
            try
            {
                sr = new StreamReader(path);
                sw = new StreamWriter("result.txt", false);
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string processedLine = line.Replace(word1, word2);
                    sw.WriteLine(processedLine);
                }
                Console.WriteLine("Changes complete. Result in the result.txt\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr?.Close();
                sw?.Close();
            }
        }

        public void Print(string? path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                Console.WriteLine("File was not found at this path.");
                return;
            }
            StreamReader? sr = null;
            try
            {
                sr = new StreamReader(path);
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
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
    }
}
