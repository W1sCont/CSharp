using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lesson10task1
{
    internal class fn10
    {
        private int count = 0;
        private int capasity = 10;
        private double[] arr;

        public fn10() { arr = new double[Capasity]; }

        public int Count { get { return count; } }
        public int Capasity { get { return capasity; } }
        private void SetCapasity(int value) { capasity += value;}

        public void AddToArr(double num)
        {
            if (Count == Capasity) Resize(10);
            arr[count] = num;
            count++;
        }
        private void Resize(int newCap)
        {
            SetCapasity(newCap);
            double[] temp = new double[Capasity];
            Array.Copy(arr, temp, count);
            arr = temp;
        }
        public fn10 this[double num] { set { AddToArr(num); } }
        public void SaveToFile(string path)
        {
            if (count == 0)
            {
                Console.WriteLine("Масив порожній, нічого записувати!");
                return;
            }
            StreamWriter fs = new StreamWriter(path, false);
            for (int i = 0; i < count; i++)
            {
                fs.Write(arr[i] + " "); 
            }

            fs.Close();
        }

        public static fn10 LoadFromFile(string path)
        {
            StreamReader fs = new StreamReader(path, Encoding.UTF8);
            string? line = fs.ReadLine();
            if (string.IsNullOrEmpty(line)) return new fn10();
            string[] str = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            fn10 result = new fn10();
            for (int i = 0;i < str.Length;i++)
            {
                result.AddToArr(Convert.ToDouble(str[i]));
            }

            fs.Close();
            return result;
        }

        public override string ToString()
        {
            if (Count == 0) return "Масив порожній";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                sb.Append(arr[i]).Append(" ");
            }
            return sb.ToString().Trim();
        }

    }
}
