using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9task3
{
    internal struct Fraction
    {
        private int _ch_;
        private int _zn_;

        public int ch { get { return _ch_; } set { _ch_ = value; } }
        public int zn 
        { 
            get { return _zn_; } 
            set 
            {
                if (value == 0) throw new ArgumentException("Знаменник не може бути нулем");
                _zn_ = value; 
            } 
        }

        private int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }

        private void minim()
        {
            int temp = gcd(Math.Abs(ch), Math.Abs(zn));
            ch /= temp;
            zn /= temp;

            if (zn < 0)
            {
                ch = -ch;
                zn = -zn;
            }
        }

        public Fraction(int ch_, int zn_)
        {
            ch = ch_;
            zn = zn_;
            if (zn == 0) throw new ArgumentException("На 0 ділити не можна!");
            minim();
        }

        public Fraction()
        {
            ch = 0;
            zn = 1;
        }

        public void SetFraction(int ch_, int zn_)
        {
            ch = ch_;
            zn = zn_;
            if (zn == 0) throw new ArgumentException("Знаменник не може бути нулем");
            minim();
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            Fraction rez = new();

            rez.ch = f1.ch * f2.zn + f2.ch * f1.zn;
            rez.zn = f1.zn * f2.zn;

            rez.minim();
            return rez;
        }

        public static Fraction operator - (Fraction f1, Fraction f2)
        {
            Fraction rez = new();
            ;

            rez.ch = f1.ch * f2.zn - f2.ch * f1.zn;
            rez.zn = f1.zn * f2.zn;

            rez.minim();
            return rez;
        }

        public static Fraction operator * (Fraction f1, Fraction f2)
        {
            Fraction rez = new();

            rez.ch = f1.ch * f2.ch;
            rez.zn = f1.zn * f2.zn;

            rez.minim();
            return rez;
        }

        public static Fraction operator / (Fraction f1, Fraction f2)
        {
            if (f2.ch == 0) throw new ArgumentException("При діленні чисельник не може бути нулем");

            Fraction rez = new();

            rez.ch = f1.ch * f2.zn;
            rez.zn = f1.zn * f2.ch;

            rez.minim();
            return rez;
        }

        public override string ToString()
        {       
            return $"{ch}/{zn}";
        }

    }
}
