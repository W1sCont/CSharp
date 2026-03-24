using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5task2
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

        public void Info()
        {
            Console.WriteLine($"ПІБ: {FullName}, Дата народження: {DateOfBirthday}, Номер телефону: {PhoneNumber}, Імейл: {Email},\n" +
                $" Посада: {Position}, Відповідальність: {Duties} \n");
        }
    }
}
