using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7task1
{
    
    internal class Date
    {
        private static readonly int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly string?[] week = { " ", "Понеділок", "Вівторок", "Середа", "Четвер", "Пятниця", "Субота", "Неділя" };
        private int day;
        private int month;
        private int year;
        private int dayOfWeek;
        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;           
            Day = day;
        }

        public Date() : this(1, 1, 0001)
        {
            dayOfWeek = 1;
        }
        public int Day 
        {
            get { return day; }
            set 
            {
                if (value < 1) day = 1;
                else if (value > daysInMonth[month]) day = (month == 2 && IsLeapYear(year) ? 29 : daysInMonth[month]);
                else day = value; 
            }
        }
        public int Month
        {
            get { return month; }
            set 
            {
                if (value < 1) month = 1;
                else if (value > 12) month = 12;
                else month = value; 
            }
        }
        public int Year
        {
            get { return year; }
            set { year = value < 1 ? 1 : value; }
        }
        public string? DayOfWeek // itn -> string
        {
            get
            {
                int totalDays = DateToDays(this.Day, this.Month, this.Year);
                int result = (totalDays - 1) % 7;
                return week[result + 1];
            }
        }

        public int DayDifference(Date obj)
        {
            int curentDate = DateToDays(Day,Month,Year);
            int valueDate = DateToDays(obj.Day, obj.Month, obj.Year);
            return Math.Abs(curentDate - valueDate);
        }

        private static int DateToDays(int day, int month, int year)
        {
            int reusltDays = 0;
            reusltDays += day;

            for (int i = 1; i < month; ++i)
            {
                if (i != 2)
                    reusltDays += daysInMonth[i];
                else reusltDays += (IsLeapYear(year) ? 29 : 28);
            }
            int poperedniYear = year - 1;
            reusltDays += poperedniYear * 365 + (poperedniYear / 4 - poperedniYear / 100 + poperedniYear / 400);
            return reusltDays;
        }
        public Date Rescheduling(int days_)
        {
            if (days_ == 0) return new Date(Day, Month, Year);

            int day = Day + days_;
            int month = Month;
            int year = Year;

            while (day > GetDaysInMonth(month, year))
            {
                day -= GetDaysInMonth(month, year);
                ++month;

                if (month > 12)
                {
                    month = 1;
                    ++year;
                }
            }
            return new Date(day, month, year);
        }
        private static int GetDaysInMonth(int month, int year)
        {
            if (month == 2) return IsLeapYear(year) ? 29 : 28;
            return daysInMonth[month];
        }
        public void Print()
        {
            Console.WriteLine($"\n{Day}/{Month}/{Year}");
            Console.WriteLine($"День тижня {DayOfWeek}\n");
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // 
        public override string ToString() { return $"{Day:D2}.{Month:D2}.{Year}"; }
        public static Date operator + (Date a, Date b)
        {
            if( b is null) return a;

            int daysIn_b = DateToDays(b.day, b.Month, b.Year);
            return a.Rescheduling(daysIn_b);
        }

        public static Date operator - (Date a, Date b)
        {
            int daysIn_a = DateToDays(a.day, a.Month, a.Year);
            int daysIn_b = DateToDays(b.day, b.Month, b.Year);
            int result = Math.Abs(daysIn_a - daysIn_b);
            Date newDate = new();
            return newDate.Rescheduling(result);
        }

        public static bool operator == (Date a, Date b)
        {
            if (a is null && b is null) { return true; }

            int daysIn_a = DateToDays(a.day, a.Month, a.Year);
            int daysIn_b = DateToDays(b.day, b.Month, b.Year);

            return daysIn_a == daysIn_b;
        }

        public static bool operator != (Date a, Date b) => !(a == b);

        public static bool operator > (Date a, Date b)
        {
            if (a is null && b is null) { return false; }

            int daysIn_a = DateToDays(a.day, a.Month, a.Year);
            int daysIn_b = DateToDays(b.day, b.Month, b.Year);

            return daysIn_a > daysIn_b;
        }

        public static bool operator < (Date a, Date b)
        {
            if (a is null && b is null) { return false; }

            int daysIn_a = DateToDays(a.day, a.Month, a.Year);
            int daysIn_b = DateToDays(b.day, b.Month, b.Year);

            return daysIn_a < daysIn_b;
        }
    }
}
