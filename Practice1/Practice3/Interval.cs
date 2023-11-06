using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Practice3
{
    public class Interval
    {
        int a, b;
        public int A {
            get { return a; } 
            set {  a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public Interval()
        {
            this.a = 1;
            this.b = 2;
        }
        public Interval(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Count(int mult, int rem)
        {
            if (a > b)
                throw new ArgumentOutOfRangeException("А має бути менша за B!");
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                if (i % mult == rem)
                    sum++;
            }
            return sum;
        }
    }
}