using System.Linq;
namespace Program_22_1
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                List<Department> departments = new List<Department>()
                {
                    new Department() {Id = 1, Country = "Ukraine", City = "Lviv"},
                    new Department(){Id = 2, Country = "Ukraine", City = "Kyiv"},
                    new Department(){Id = 3, Country =  "France", City = "Paris"},
                    new Department(){Id = 4, Country =  "Ukraine", City = "Odesa"}
                };
                List<Employee> employees = new List<Employee>()
                {
                    new Employee()
                        { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                    new Employee()
                        { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                    new Employee()
                        { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                    new Employee()
                        { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                    new Employee()
                        { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                    new Employee()
                        { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                    new Employee()
                        { Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4 }
                };
                
                Console.WriteLine("Task 1");
                Console.WriteLine("\nВпорядкувати імена та прізвища працівників за алфавітом, які проживають в Україні. Виконати запит негайно.\n");
                var nr1 = employees.Where(i => (departments.Where(u => u.Country == "Ukraine").Select(u => u.Id)).Contains(i.DepId))
                    .OrderBy(i => i.LastName).ThenBy(i => i.FirstName).ToList();
                foreach (var v in nr1)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine();
                var nr11 = employees.Join(departments, emp => emp.DepId, dep => dep.Id, (emp, dep) => new { emp, dep })
                    .Where(i => i.dep.Country == "Ukraine").OrderBy(i => i.emp.LastName).ThenBy(i => i.emp.FirstName)
                    .Select(i => $"{i.emp.LastName} {i.emp.FirstName}").ToList();
                foreach (var v in nr11)
                {
                    Console.WriteLine(v);
                }
                
                Console.WriteLine("Task 2");
                Console.WriteLine("Відсортувати співробітників за віком за спаданням. Вивести Id, FirstName, LastName, Age. Виконати запит негайно.");
                var nr2 = employees.OrderByDescending(i => i.Age).Select(i => $"{i.Id} {i.FirstName} {i.LastName} {i.Age}").ToList();
                foreach (var v in nr2)
                {
                    Console.WriteLine(v);
                }

                Console.WriteLine("Task 3");
                Console.WriteLine("Згрупувати студентів за віком. Вивести вік і скільки разів він зустрічається у списку.");

                var nr3 = employees.GroupBy(i => i.Age).Select(s => $"Age: {s.Key}, Count: {s.Count()}");
                foreach (var v in nr3)
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