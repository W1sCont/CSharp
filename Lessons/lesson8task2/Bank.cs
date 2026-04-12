using System;
using System.Collections.Generic;
using System.Text;

namespace lesson8task2
{
    internal class Bank
    {
        int balans;
        public int BankID { get; set; }
        public string? Name { get; set; }
        public int Balans 
        {   get { return balans; }
            set
            {
                if (value > 0) balans = value;
                if (value <= 0) throw new Exception("Відємна сума не достуна");
            } 
        }

        public Bank(int bankID, string? name, int balans)
        {
            BankID = bankID;
            Name = name;
            Balans = balans;
        }
        public Bank() { BankID = 0; Name = "User name"; Balans = 1000; }

        public void Deposit(int amount) 
        {
            if (amount > 0) Balans += amount;
            else throw new Exception("Не може бути відємним");
        }
        public void Get(int amount)
        {
            if (Balans >= amount) { Balans -= amount; }
            else throw new Exception("Не достатньо коштів");
        }
        public void Info() { Console.WriteLine($"ID: {BankID}, Ім'я: {Name}, Баланс: {Balans}"); }
    }
}
