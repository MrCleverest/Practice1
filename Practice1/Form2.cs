using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                // Оголошення та зчитування
                string surname, surname1, surname2, surname3, surname4;
                surname = textBox1.Text;
                surname1 = textBox2.Text;
                surname2 = textBox3.Text;
                surname3 = textBox4.Text;
                surname4 = textBox5.Text;

                // Ініціалізація масиву та сортування
                Arrays surnames = new Arrays(surname, surname1, surname2, surname3, surname4);
                surnames.SortByLastLetter();

                // Виведення в таблицю
                for(int i = 0; i < surnames.Length; i++)
                {
                    dataGridView1.Rows.Add(surnames[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
