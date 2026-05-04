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
                DicT<string, string> ditc = new DicT<string, string>();
                ditc.Add("Hi", "Bonjour");
                ditc.Add("Apple", "Pomme");
                ditc.Add("Book", "Livre");
                ditc.Add("Cat", "Chat");
                ditc.Add("House", "Maison");
                ditc.Add("Water", "Eau");
                ditc.Add("Friend", "Ami / Amie");
                ditc.Add("Sun", "Soleil");
                ditc.Add("Night", "Nuit");
                ditc.Add("Work", "Travail");
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}