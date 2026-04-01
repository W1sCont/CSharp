using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8task1
{
    internal class ClassEmployee
    {
        public string? FullName {  get; set; }
        public string? DateOfBirthday { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public string? Duties { get; set; }

        public ClassEmployee()
        {
            FullName = "Ivan Franko";
            DateOfBirthday = "27 серпня 1856";
            PhoneNumber = "+3800000000";
            Email = "ivanko27@urkaine.com";
            Position = "поет";
            Duties = "Прозаїк, драматург, літературний критик, публіцист, перекладач, науковець, громадський і політичний діяч. Доктор філософії";
        }

        public ClassEmployee(string? name)
        {
            FullName = name;
            DateOfBirthday = "none";
            PhoneNumber = "none";
            Email = "none";
            Position = "none";
            Duties = "none";
        }

        public void Info()
        {
            Console.WriteLine($"ПІБ: {FullName}, Дата народження: {DateOfBirthday}, Номер телефону: {PhoneNumber}, Імейл: {Email},\n" +
                $" Посада: {Position}, Відповідальність: {Duties}\n");
        }

        public (string? type, double salary) CalculateSalary(double baseRate)
        {
            return ("фіксована ставка ", baseRate);
        }

        public (string? type, double salary) CalculateSalary(double hourlyRate, int hoursWorked)
        {
            double total = hourlyRate * hoursWorked;
            return ($"погодинна оплата ({hoursWorked} год.) ", total);
        }

        public (string? type, double salary) CalculateSalary(double baseRate, double bonusPercentage)
        {
            double total = baseRate + (baseRate * bonusPercentage / 100);
            return ($"ставка з урахуванням премії {bonusPercentage}% ", total);
        }
        public static void PrintInfo(string name, (string note, double salary) data)
        {
            Console.WriteLine($"Працівник: {name}");
            Console.WriteLine($"Нараховано: {data.salary:F2} грн");
            Console.WriteLine($"Примітка: {data.note}");
            Console.WriteLine();
        }
    }
}
