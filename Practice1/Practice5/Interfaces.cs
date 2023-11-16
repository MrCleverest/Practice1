using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1.Practice5
{
    public partial class Interfaces : Form
    {
        // Змінні для авто та шляху до файлу
        Automobiles cars = new Automobiles();
        string path = "data.txt";
        // метод для виведення колекції
        public void show(DataGridView dg)
        {
            dg.Rows.Clear();
            foreach (Car c in cars.cars)
            {
                dg.Rows.Add(c.Brand, c.Owner, c.Year, c.Mileage);
            }
        }
        public void grid(DataGridView data)
        {
            data.Rows.Clear();
            data.ColumnCount = 4;
            data.Columns[0].Name = "Марка";
            data.Columns[1].Name = "Власник";
            data.Columns[2].Name = "Рік";
            data.Columns[3].Name = "Пробіг";
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public Interfaces()
        {
            InitializeComponent();
            grid(dataGridView1);
            grid(dataGridView2);
            grid(dataGridView3);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car(
                    BrandBox.Text,
                    OwnerBox.Text,
                    Convert.ToInt32(YearBox.Text),
                    Convert.ToInt32(MileageBox.Text)
                    );
                cars.add(car);
                dataGridView1.Rows.Add(
                    cars.cars[cars.cars.Count - 1].Brand,
                    cars.cars[cars.cars.Count - 1].Owner,
                    cars.cars[cars.cars.Count - 1].Year,
                    cars.cars[cars.cars.Count - 1].Mileage);
            }
            catch
            {
                MessageBox.Show("Помилка у вхідних даних!");
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            cars.writeFile(path);
            MessageBox.Show("Дані записані");
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            cars.readFile(path);
            show(dataGridView1);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var i = dataGridView1.CurrentRow.Index;
            cars.remove(i);
            show(dataGridView1);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            cars.sort();
            show(dataGridView2);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            cars.cars.Sort();
            dataGridView3.Rows.Clear();
            foreach(Car c in cars.cars)
            {
                if(c.Year>Convert.ToInt32(SortBox.Text))
                    dataGridView3.Rows.Add(c.Brand, c.Owner, c.Year, c.Mileage);
            }
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}