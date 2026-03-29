using lesson6task2;
class MainClass
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        try
        {
            ListOfBooks myLibrary = new ListOfBooks();
            myLibrary.Add(new Book("Kobzar", "Shevchenko", 1840));

            Book richter = new Book(); 
            myLibrary += richter;

            Console.WriteLine($"Кількість книг: {myLibrary.Count}");
            myLibrary.Print();

            Console.WriteLine("Видаляємо Ріхтера");
            myLibrary -= richter;

            myLibrary.Print();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

