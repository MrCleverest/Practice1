using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Arrays2D
    {
        public bool error = false;
        int x_length = 5;
        int y_length = 5;
        int[,] a;

        public int X_length
        {
            get { return x_length; }
            set { x_length = value; }
        }
        public int Y_length
        {
            get { return y_length; }
            set { y_length = value; }
        }
        public int this[int i, int j]
        {
            get
            {
                if(0<=i && i < x_length && 0 <=j && j < y_length)
                    return a[i,j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if(0 <= i && i < x_length && 0 <= j && j < y_length)
                {
                    error = true;
                }
            }
        }
        public Arrays2D()
        {
            a = new int[x_length, y_length];
            Random random = new Random();
            for(int i = 0; i < x_length; i++)
                for(int j = 0; j < y_length; j++)
                    a[i,j] = random.Next(-10,10);
        }
        public Arrays2D(int a_length, int b_length)
        {
            X_length = a_length;
            Y_length = b_length;

            a = new int[x_length, y_length];
            Random random = new Random();
            for (int i = 0; i < x_length; i++)
                for (int j = 0; j < y_length; j++)
                    a[i, j] = random.Next(-10, 10);
        }
        public string Index_number()
        {
            string str = "";
            for (int i = 0; i < x_length; i++)
                for (int j = 0; j < y_length; j++)
                    if (a[i, j] < 0)
                        str += "[" + i + "," + j + "],";
            str = str.Substring(0, str.Length - 1);
            return str;
        }
    }
}
