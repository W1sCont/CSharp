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
            if (Count == Capasity) SetCapasity(10);
            arr[count] = num;
            count++;
        }

        public fn10 this[double num] { set { AddToArr(num); } }
        public void SaveToFile(string pass)
        {
            StreamWriter fs = new StreamWriter(pass, true);
            for (int i = 0; i < count; i++) { fs.Write(arr[i] + ","); }
            fs.Close();
        }

        public void LoadFromFile(string pass)
        {
            StreamReader fs = new StreamReader(pass);
        }
    }
}
