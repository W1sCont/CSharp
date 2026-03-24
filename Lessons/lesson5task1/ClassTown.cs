using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5task1
{
    internal class ClassTown
    {
        private string? name;
        private string? country;
        private int countOfSityzen;
        private int postCode;
        private string? district;

        public ClassTown() 
        {
            name = "town";
            country = "country";
            countOfSityzen = 100;
            postCode = 82400;
            district = "district";
        }


        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public string? Country
        {
            get { return country; }
            set { country = value; }
        }

        public int CountOfSityzen
        {
            get { return countOfSityzen; }
            set { countOfSityzen = value; }
        }

        public int PostCode
        {
            get { return postCode;}
            set { postCode = value; }
        }
        
        public string? District
        {
            get { return district; }
            set { district = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Назва міста: {Name} , Назва країни: {Country} , К-сть мешканців: {CountOfSityzen} ,\n" +
                $" Поштовий код: {PostCode} , Район: {District} \n");
        }

        public void SetData()
        {
            Console.WriteLine("Назва міста: ");
            Name = Console.ReadLine();
            Console.WriteLine("Назва країни: ");
            Country = Console.ReadLine();
            Console.WriteLine("К-сть мешканців: ");
            CountOfSityzen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Поштовий код: ");
            PostCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Район: ");
            District = Console.ReadLine();
        }

    }
}
