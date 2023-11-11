using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1.Practice4
{
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArraysAB a = new ArraysAB(100);
            FileWrite f = new FileWrite();
            FileRead f2 = new FileRead();
            ShowArray show = new ShowArray();
            string patch = @"C:\Users\Mishel\Documents\1.txt";
            string patch1 = @"C:\Users\Mishel\Documents\2.txt";
            f2.Read(patch, a);
            a.calculate();
            f.Write(patch1, a);
            label3.Text = show.writeArray(a.a);
            label4.Text = show.writeArray(a.b);

        }
    }
}