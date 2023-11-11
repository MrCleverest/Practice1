using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Practice4
{
    internal class ShowArray
    {
        public string writeArray(int[] array)
        {
            string s = "";
            foreach (double i in array)
            {
                s += i.ToString() + " ";
            }
            return s;
        }
        public string writeArray(double[] array)
        {
            string s = "";
            foreach (double i in array)
            {
                s += i.ToString() + " ";
            }
            return s;
        }
    }
}
