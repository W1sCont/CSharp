using lesson9task3;
namespace Fractal.Test
{
    class MainClass
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.WriteLine("Test");
                Fraction f1 = new();
                f1.SetFraction(4, 7);
                Console.WriteLine($"{f1}");
                Fraction f2 = new(3, 4);
                Console.WriteLine($"{f2}\n");
                Console.WriteLine($"Додавайння: {f1} + {f2} = {f1 + f2}");
                Console.WriteLine($"Відніиання: {f1} - {f2} = {f1 - f2}");
                Console.WriteLine($"Добуток: {f1} * {f2} = {f1 * f2}");
                Console.WriteLine($"Ділення: {f1} / {f2} = {f1 / f2}");

                Console.WriteLine($"Початкові дроби: f1 = {f1}, f2 = {f2}\n");

                while (true)
                {
                    Console.WriteLine("Оберіть операцію (+, -, *, /) або ' ' для виходу:");
                    string? op = Console.ReadLine();

                    if (op == " ") break;

                    if (op != "+" && op != "-" && op != "*" && op != "/")
                    {
                        Console.WriteLine("Невірний оператор, спробуйте ще раз.");
                        continue;
                    }

                    Console.Write("Введіть перший дріб (наприклад, 3/4): ");
                    string? input = Console.ReadLine();

                    string[] parts = input.Split('/');

                    if (parts.Length == 2)
                    {
                        f1.ch = int.Parse(parts[0].Trim());
                        f1.zn = int.Parse(parts[1].Trim());
                    }

                    Console.Write("Введіть другий дріб (наприклад, 3/4): ");
                    input = Console.ReadLine();

                    parts = input.Split('/');

                    if (parts.Length == 2)
                    {
                        f2.ch = int.Parse(parts[0].Trim());
                        f2.zn = int.Parse(parts[1].Trim());
                    }

                    switch (op)
                    {
                        case "+":
                            Console.WriteLine($"Результат додавання: {f1} + {f2} = {f1 + f2}");
                            break;
                        case "-":
                            Console.WriteLine($"Результат віднімання: {f1} - {f2} = {f1 - f2}");
                            break;
                        case "*":
                            Console.WriteLine($"Результат множення: {f1} * {f2} = {f1 * f2}");
                            break;
                        case "/":
                            Console.WriteLine($"Результат ділення: {f1} / {f2} = {f1 / f2}");
                            break;
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

