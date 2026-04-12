using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6task2
{
    internal class Book
    {
        public Book(string? name, string? author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }
        public Book()
        {
            Name = "CLR via C#";
            Author = "Jefri Richter";
            Year = 2013;
        }

        public string? Name { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public void Info() { Console.WriteLine($"Назва: {Name}, Автор: {Author}, Рік видання: {Year}"); }

        public static bool operator ==(Book? b1, Book? b2)
        {
            if (ReferenceEquals(b1, b2)) return true;

            if (b1 is null || b2 is null) return false;

            return b1.Name == b2.Name && b1.Author == b2.Author && b1.Year == b2.Year;
        }

        public static bool operator !=(Book? b1, Book? b2) => !(b1 == b2);

    }
}

