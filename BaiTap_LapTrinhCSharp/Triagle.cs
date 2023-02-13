using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LapTrinhCSharp
{
    public class Triagle : Sharp
    {
        private int a, b, c;

        public Triagle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triagle(int[] triagle)
        {
            this.a = triagle[0];
            this.b = triagle[1];
            this.c = triagle[2];
        }

        public Triagle()
        {
        }

        public int getA()
        {
            return a;
        }

        public void setA(int a)
        {
            this.a = a;
        }

        public int getB()
        {
            return b;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public int getC()
        {
            return c;
        }

        public void setC(int c)
        {
            this.c = c;
        }

        public override bool checkInput()
        {
            if (a <= 0 || b <= 0 || c <= 0 || (a + b) <= c || (b + c) <= a || (c + a) <= b)
                return false;
            return true;
        }

        public override double getArea()
        {
            double p = (this.a + this.b + this.c) / 2;

            double S = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));

            return S;
        }

        public override double getperimeter()
        {
            return this.a + this.b + this.c;
        }

    }
}
