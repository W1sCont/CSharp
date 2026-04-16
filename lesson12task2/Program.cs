using lesson12task2;

namespace Lesson_12_2
{
    class MyClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            try
            {
                Builder Ivan = new Builder("Ivan", "Strong", 45, "Bricklayer");
                Sailor Petro = new Sailor("Petro", "Traid", 34, 1000);
                Pilot Roman = new Pilot("Roman", "Romanoff", 26, "Civil Aviation");
                Ivan.Info();
                Petro.Info();
                Roman.Info();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}