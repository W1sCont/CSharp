using System.Linq;
namespace Program_22_3
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
                Console.WriteLine("\nВибрати імена та прізвища співробітників, які працюють в Україні, але не в Одесі.\n");
                var nr1 = employees.Join(departments, emp => emp.DepId, dep => dep.Id, (emp, dep) => new { emp, dep })
                    .Where(i => i.dep.Country == "Ukraine" & i.dep.City != "Odesa")
                    .Select(i => $"{i.emp.FirstName} {i.emp.LastName}");
                foreach (var v in nr1)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine();
                var nr11 = from emp in employees
                    join dep in departments on emp.DepId equals dep.Id
                    where dep.Country == "Ukraine" & dep.City != "Odesa"
                    select $"{emp.FirstName} {emp.LastName}";
                        
                foreach (var v in nr11)
                {
                    Console.WriteLine(v);
                }
                
                Console.WriteLine("\nTask 2");
                Console.WriteLine("\nВивести список країн без повторень.\n");
                var nr2 = departments.Select(i => i.Country).Distinct();
                foreach (var v in nr2)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine();
                var nr22 = (from dep in departments  select dep.Country).Distinct();
                foreach (var v in nr22)
                {
                    Console.WriteLine(v);
                }

                Console.WriteLine("\nTask 3");
                Console.WriteLine("\nВибрати 3-х перших співробітників, вік яких перевищує 25 років.\n");

                var nr3 = employees.Where(i => i.Age > 25).Take(3).Select(i => $"{i.LastName} {i.FirstName}");
                foreach (var v in nr3)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine();
                var nr33 = (from emp in employees
                    where emp.Age > 25
                    select emp).Take(3);
                foreach (var v in nr33)
                {
                    Console.WriteLine(v);
                }
                
                Console.WriteLine("\nTask 4");
                Console.WriteLine("\nВибрати імена, прізвища та вік студентів з Одеси, вік яких перевищує 27 років.\n");
                var nr4 = employees.Join(departments, emp => emp.DepId, dep => dep.Id, (emp, dep) => new { emp, dep })
                    .Where(i => i.emp.Age > 27).Where(i => i.dep.City == "Odesa")
                    .Select(i => $"{i.emp.FirstName} {i.emp.LastName} {i.emp.Age}"); 
                foreach (var v in nr4)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine();
                var nr44 = from emp in employees
                    join dep in departments on emp.DepId equals dep.Id
                    where emp.Age > 27
                    where dep.City == "Odesa"
                    select $"{emp.FirstName} {emp.LastName} {emp.Age}";
                foreach (var v in nr44)
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