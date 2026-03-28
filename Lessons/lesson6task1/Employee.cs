using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6task1
{
    internal class ClassEmployee
    {
        public string? FullName { get; set; }
        public string? DateOfBirthday { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public string? Duties { get; set; }
        public int Salary { get; set; }

        public ClassEmployee()
        {
            FullName = "Ivan Franko";
            DateOfBirthday = "27 серпня 1856";
            PhoneNumber = "+3800000000";
            Email = "ivanko27@urkaine.com";
            Position = "поет";
            Duties = "Прозаїк, драматург, літературний критик, публіцист, перекладач, науковець, громадський і політичний діяч. Доктор філософії";
            Salary = 1000;
        }

        public ClassEmployee(string? fullName, string? dateOfBirthday, string? phoneNumber, string? email, string? position, string? duties, int salary)
        {
            FullName = fullName;
            DateOfBirthday = dateOfBirthday;
            PhoneNumber = phoneNumber;
            Email = email;
            Position = position;
            Duties = duties;
            Salary = salary;
        }

        public void Info()
        {
            Console.WriteLine($"ПІБ: {FullName},\t Дата народження: {DateOfBirthday},\nНомер телефону: {PhoneNumber},\t Імейл: {Email},\n" +
                $"Посада: {Position},\t Відповідальність: {Duties},\nЗаробітня плата: {Salary} \n");
        }

        public static ClassEmployee operator + (ClassEmployee obj, int add)
        {
            return new ClassEmployee
            {
                FullName = obj.FullName,
                DateOfBirthday = obj.DateOfBirthday,
                PhoneNumber = obj.PhoneNumber,
                Email = obj.Email,
                Position = obj.Position,
                Duties = obj.Duties,
                Salary = obj.Salary + add
            };
        }

        public static ClassEmployee operator - (ClassEmployee obj, int add)
        {
            return new ClassEmployee
            {
                FullName = obj.FullName,
                DateOfBirthday = obj.DateOfBirthday,
                PhoneNumber = obj.PhoneNumber,
                Email = obj.Email,
                Position = obj.Position,
                Duties = obj.Duties,
                Salary = obj.Salary - add
            };
        }

        public static bool operator == (ClassEmployee obj1, ClassEmployee obj2)
        {
            return obj1.Salary == obj2.Salary;
        }
        public static bool operator != (ClassEmployee obj1, ClassEmployee obj2)
        {
            return obj1.Salary != obj2.Salary;
        }
        public static bool operator > (ClassEmployee obj1, ClassEmployee obj2)
        {
            return obj1.Salary > obj2.Salary;
        }
        public static bool operator < (ClassEmployee obj1, ClassEmployee obj2)
        {
            return obj1.Salary < obj2.Salary;
        }

    }
}
