using System.Linq;
namespace Program_23_1
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Car[] car = new[]
                {
                    new Car("Honda", "Accord", 1999),
                    new ElectroCar("Tesla", "X", 2024, 45000),
                    new Car("Audi", "A8", 2026),
                    new ElectroCar("Audi", "Green", 2025, 47000)
                };

                foreach (var v in car)
                {
                    v.PrintInfo();
                }
                
                Console.WriteLine();
                var nr2 = car.Where(i => i is ElectroCar);
                foreach (var v in nr2)
                {
                    v.PrintInfo();
                }
                
                Console.WriteLine();
                var nr3 = car.MaxBy(i => i.Year);
                nr3.PrintInfo();
                
                Console.WriteLine();
                var nr4 = car.Where(i => i is ElectroCar).OfType<ElectroCar>().MaxBy(e => e.BatteryCapacity);
                nr4.PrintInfo();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}