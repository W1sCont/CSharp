using System.Linq;
namespace Program_21_1
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                List<Person> person = new List<Person>()
                {
                    new Person() { Name = "Andrey", Age = 24, City = "Kyiv" },
                    new Person() { Name = "Liza", Age = 18, City = "Odesa" },
                    new Person() { Name = "Oleg", Age = 15, City = "London" },
                    new Person() { Name = "Sergey", Age = 55, City = "Kyiv" },
                    new Person() { Name = "Sergey", Age = 32, City = "Lviv" }
                };
                
                var nr1 = from i in person where (i.Age > 25) select i;
                Console.WriteLine("\nAge > 25");  
                foreach (var v in nr1)
                {
                    Console.WriteLine(v);   
                }
                Console.WriteLine();  
                var nr11 = person.Where(p => p.Age > 25);
                foreach (var v in nr11)
                {
                    Console.WriteLine(v);   
                }
                
                var nr2 = from i in person where (i.City == "London") select i;
                Console.WriteLine("\nCity == London");  
                foreach (var v in nr2)
                {
                    Console.WriteLine(v);   
                }
                Console.WriteLine(); 
                var nr22 = person.Where(p => p.City == "London");
                foreach (var v in nr22)
                {
                    Console.WriteLine(v);   
                }
                
                var nr3 = from i in person where (i.City == "Kyiv") select i.Name;
                Console.WriteLine("\nCity == Kyiv, Name");  
                foreach (var v in nr3)
                {
                    Console.WriteLine(v);   
                }
                Console.WriteLine(); 
                var nr33 = person.Where(p => p.City == "Kyiv").Select(p => p.Name);
                foreach (var v in nr33)
                {
                    Console.WriteLine(v);   
                }
                
                var nr4 = from i in person where (i.Age > 35 && i.Name == "Sergey") select i;
                Console.WriteLine("\nAge > 35, Name == Sergey");  
                foreach (var v in nr4)
                {
                    Console.WriteLine(v);   
                }
                Console.WriteLine(); 
                var nr44 = person.Where(p => p.Age > 35 && p.Name == "Sergey");
                foreach (var v in nr44)
                {
                    Console.WriteLine(v);   
                }
                
                var nr5 = from i in person where (i.City == "Odesa") select i;
                Console.WriteLine("\nCity ==  Odesa");  
                foreach (var v in nr5)
                {
                    Console.WriteLine(v);   
                }
                Console.WriteLine(); 
                var nr55 = person.Where(p => p.City == "Odesa");
                foreach (var v in nr55)
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