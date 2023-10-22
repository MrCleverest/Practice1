using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Tabul
    {
        // Поле з результуючим масивом
        public double[,] xy = new double[1000, 2];
        // Реальна кількість елементів в масиві
        public int n = 0;
        // Методи для обрахунку функцій
        private double f1(double x)
        {
            return (Math.Tan(x + 3) * Math.Tan(x + 3)) / (Math.Pow(Math.Abs(x), 1.2) * Math.Sin(3 * x));
        }
        private double f2(double x)
        {
            return (Math.Pow(x, 3)-4*x+2/x*x+Math.Sin(7*x)-1);
        }
        private double f3(double x)
        {
            return (Math.Tan(0.1 * Math.PI * x * x) + x) / (Math.Cos(x + 1) * Math.Cos(x + 1));
        }
        // Метод табулювання
        public void tab(double xn = -1.7, double xk=45.3, double h = 0.1, double a = 0.3)
        {
            double x = xn, y;
            int i = 0;
            while(x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if((x>=0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }
    }
}
