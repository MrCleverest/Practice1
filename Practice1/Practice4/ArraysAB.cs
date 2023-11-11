using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Practice4
{
    public class ArraysAB
    {
        public int[] a;
        public double[] b;
        int length = 0;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public ArraysAB(int n)
        {
            a = new int[n];
        }

        public void calculate()
        {
            Array.Resize(ref a, length);
            b = new double[length];

            for (int i = 0; i < length - 1; i += 2)
            {
                double first = a[i];
                double second = a[i + 1];

                if (first < 0 && second < 0)
                {
                    // обидва числа від’ємні, збільшити на 0.5
                    b[i] = first + 0.5;
                    b[i + 1] = second + 0.5;
                }
                else if (first < 0 || second < 0)
                {
                    // тільки одне число від’ємне, замінити його квадратом
                    b[i] = (first < 0) ? first * first : first;
                    b[i + 1] = (second < 0) ? second * second : second;
                }
                else
                {
                    // обидва числа позитивні, замінити на середнє арифметичне вихідних значень
                    b[i] = (first + second) / 2.0;
                    b[i + 1] = (first + second) / 2.0;
                }
            }

            // Якщо кількість елементів непарна, обробимо останній елемент
            if (length % 2 == 1)
            {
                double lastNumber = a[length - 1];
                b[length - 1] = (lastNumber < 0) ? lastNumber * lastNumber : lastNumber;
            }
        }
    }
}
