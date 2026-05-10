using System.Linq;
namespace Program_21_2
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                List<Good> goods1 = new List<Good>()
                {
                    new Good() { Id = 1, Title = "Nokia 1100", Price = 450.99, Category = "Mobile" },
                    new Good() { Id = 2, Title = "Iphone 4", Price = 5000, Category = "Mobile" },
                    new Good() { Id = 3, Title = "Refregirator 5000", Price = 2555, Category = "Kitchen" },
                    new Good() { Id = 4, Title = "Mixer", Price = 150, Category = "Kitchen" },
                    new Good() { Id = 5, Title = "Magnitola", Price = 1499, Category = "Car" },
                    new Good() { Id = 6, Title = "Samsung Galaxy", Price = 3100, Category = "Mobile" },
                    new Good() { Id = 7, Title = "Auto Cleaner", Price = 2300, Category = "Car" },
                    new Good() { Id = 8, Title = "Owen", Price = 700, Category = "Kitchen" },
                    new Good() { Id = 9, Title = "Siemens Turbo", Price = 3199, Category = "Mobile" },
                    new Good() { Id = 10, Title = "Lighter", Price = 150, Category = "Car" }
                };

                var nr1 = goods1.Where(g => g.Category == "Mobile" && g.Price > 1000);
                Console.WriteLine("Вибрати товари категорії Mobile, вартість яких перевищує 1000.");
                foreach (var v in nr1)
                {
                    Console.WriteLine(v);
                }

                var nr2 = from i in goods1 where (i.Category != "Kitchen" && i.Price > 1000) select (i.Title, i.Price);
                Console.WriteLine(
                    "\nВивести назву та ціну тих товарів, які не відносяться до категорії Kitchen, ціна яких перевищує 1000");
                foreach (var v in nr2)
                {
                    Console.WriteLine(v);
                }

                var nr3 = goods1.Average(i => i.Price);
                Console.WriteLine("\nОбчислити середнє значення всіх цін товарів");
                Console.WriteLine($"Result: {nr3}");

                var nr4 = goods1.Select(i => i.Category).Distinct();
                Console.WriteLine("\nВивести список категорій без повторення");
                foreach (var v in nr4)
                {
                    Console.WriteLine(v);
                }

                var nr5 = from i in goods1 orderby i.Title select (i.Title, i.Category);
                Console.WriteLine("\nВивести назви та категорії товарів в алфавітному порядку,упорядкованих за назвою");
                foreach (var v in nr5)
                {
                    Console.WriteLine(v);
                }

                var nr6 = goods1.Count(i => i.Category == "Car") + goods1.Count(i => i.Category == "Mobile");
                Console.WriteLine("\nПорахувати сумарну кількість товарів категорій Сar та Mobile");
                Console.WriteLine($"Result: {nr6}");

                var nr7 = from i in goods1 group i by i.Category into g orderby g.Key select (g.Key, g.Count());
                Console.WriteLine("\nВивести список категорій та кількість товарів кожної категорії");
                foreach (var v in nr7)
                {
                    Console.WriteLine(v);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}