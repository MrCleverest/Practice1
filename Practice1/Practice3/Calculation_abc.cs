using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Practice3
{
    public class Calculation_abc
    {
        int a, b, c;
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }
        public Calculation_abc()
        {
            this.a = 1;
            this.b = 2;
            this.c = 3;
        }
        public Calculation_abc(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double D()
        {
            if (a >= 0 || b >= 0 || c >= 0)
                return Math.Pow((a + b + c), 2);
            else
                return Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
        }
    }
}
