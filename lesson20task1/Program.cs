using lesson20task1;
namespace Program_20
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                DicT<string, string> dict = new DicT<string, string>();
                bool stop = true;
                while (stop)
                {
                    foreach (var k in dict)
                    {
                        Console.Write(k.Key + " - ");
                        Console.Write(string.Join(", ", k.Value));
                        Console.WriteLine();
                    }
                    Console.WriteLine("1-Add word and translate, 2-Remove word, 3-Remove translate, 4-Edit word, 5-Edit translate, 6-Find, 0-Exit");

                    string? choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Enter word:");
                            string? word = Console.ReadLine();
                            Console.WriteLine("Enter translate:");
                            string? translate = Console.ReadLine();
                            if (word != null && translate != null)
                            {
                                dict.Add(word, translate);
                                Console.WriteLine($"Word {word} added");
                            }
                            else { Console.WriteLine("Field cant be empty!"); }
                            break;
                        case "2":
                            Console.WriteLine("Enter word:");
                            word = Console.ReadLine();
                            if (dict.Find(word))
                            {
                                dict.Dell(word);
                                Console.WriteLine($"Word {word} deleted");
                            }
                            else { Console.WriteLine($"Word {word} not found"); }
                            break;
                        case "3":
                            Console.WriteLine("Enter word:");
                            word = Console.ReadLine();
                            if (dict.Find(word))
                            {
                                dict.DellTranslate(word);
                                Console.WriteLine($"Translate of {word} is deleted");
                            }
                            else
                            {
                                Console.WriteLine($"Word {word} not found");
                            }
                            break;
                        case "4":
                            Console.WriteLine("Enter word:");
                            word = Console.ReadLine();
                            if (dict.Find(word))
                            {
                                Console.WriteLine("Enter new word:");
                                string? newWord = Console.ReadLine();
                                if (newWord != null)
                                {
                                    dict.EditWord(word, newWord);
                                    Console.WriteLine($"Translate of {word} edited");
                                }
                                else { Console.WriteLine("Field cant be empty!"); }
                            }
                            else
                            {
                                Console.WriteLine($"Word {word} not found");
                            }
                            break;
                        case "5":
                            Console.WriteLine("Enter word:");
                            word = Console.ReadLine();
                            if (dict.Find(word))
                            {
                                Console.WriteLine("Enter new word:");
                                string? newWord = Console.ReadLine();
                                if (newWord != null)
                                {
                                    dict.Edit(word, newWord);
                                    Console.WriteLine($"Translate edited");
                                }
                                else { Console.WriteLine("Field cant be empty!"); }
                            }
                            else
                            {
                                Console.WriteLine($"Word {word} not found");
                            }
                            break;
                        case "6":
                            Console.WriteLine("Enter word:");
                            word = Console.ReadLine();
                            if (dict.Find(word))
                            {
                                Console.WriteLine($"Translate of {word} is {dict[word]}");
                                dict.Dell(word);
                            }
                            else
                            {
                                Console.WriteLine($"Word {word} not found");
                            }
                            break;
                        case "0":
                            stop = false;
                            break;
                    }
                }
                
                /*
                str.Add("Bonjour");
                ditc.Add("Hi", str);
                ditc.Add("Apple", new List<string>(){"Pomme"});
                ditc.Add("Book", new List<string>(){"Livre"});
                ditc.Add("Cat", new List<string>(){"Chat"});
                ditc.Add("House", new List<string>(){"Maison"});
                ditc.Add("Water", new List<string>(){"Eau"});
                ditc.Add("Friend", new List<string>(){"Ami", "Amie"});
                ditc.Add("Sun", new List<string>(){"Soleil"});
                ditc.Add("Night", new List<string>(){"Nuit"});
                ditc.Add("Work", new List<string>(){"Travail"});
                // Love - Amour
                ditc.Find("Hi");
                ditc.Edit("Hi", "Salut");
                ditc.Find("Hi");
                ditc.DellTranslate("Hi");
                ditc.Find("Hi");
                ditc.Edit("Hi", "Bonsoir");
                ditc.EditWord("Hi", "Hello");
                ditc.Find("Hello");
                ditc.Dell("Hello");
                ditc.Find("Hello");
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}