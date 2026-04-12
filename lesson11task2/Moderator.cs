using System;
using System.IO;

namespace lesson11task2;

public class Moderator
{ 
    StreamReader sr = null;
    StreamReader KayFile = null;
    StreamWriter sw = null;

    public void Mod(string? path1, string? path2)
    {
        try
        {
            if (string.IsNullOrEmpty(path1) || !File.Exists(path1) || string.IsNullOrEmpty(path2) || !File.Exists(path2))
            {
                Console.WriteLine("File was not found.");
                return;
            }
            sr = new StreamReader(path1);
            KayFile = new StreamReader(path2);
            sw = new StreamWriter("result.txt", false);
            
            string? validWords = KayFile.ReadToEnd();
            string?[] words = validWords.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string? line;
            while ((line = sr.ReadLine()) != null)
            { 
                string processedLine = line;
                foreach (string badWord in words)
                {
                    if (processedLine.Contains(badWord, StringComparison.OrdinalIgnoreCase))
                    {
                        string replacement = new string('*', badWord.Length);
                        processedLine = processedLine.Replace(badWord, replacement, StringComparison.OrdinalIgnoreCase);
                    }
                }
                sw.WriteLine(processedLine);
            }
            Console.WriteLine("Moderation complete. Result in result.txt\n");

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            sr.Close();
            KayFile.Close();
            sw.Close();
        }
    }
}