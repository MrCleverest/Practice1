using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice1.Practice6
{
    public partial class Events : Form
    {
        private EventNotifier eventNotifier = new EventNotifier();
        private Worker worker = new Worker();

        public Events()
        {
            InitializeComponent();
            eventNotifier.Activate += EventNotifier_Activate;
            eventNotifier.NewOrderEvent += EventNotifier_NewOrderEvent;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void startEvent_Click(object sender, EventArgs e)
        {
            eventNotifier.TriggerNewOrderEvent();
            eventNotifier.TriggerEvent();
        }
        private void EventNotifier_Activate()
        {
            try
            {
                if (int.TryParse(textBox1.Text, out int houseCount)) {
                    if (houseCount < 1)
                    {
                        throw new Exception();
                    }
                    Worker worker = new Worker();
                    HR hr = new HR();
                    Engineer engineer = new Engineer();
                    Administration admin = new Administration();
                    worker.BuildHouses(houseCount);
                    if (houseCount > 1)
                    {
                        engineer.EngineerEvent();
                        houseCount -= 1;
                    }
                    if (houseCount > 4)
                    {
                        hr.HREvent();
                        houseCount -= 1;
                    }
                    if (houseCount > 15)
                    {
                        admin.AdministrationEvent();
                        houseCount -= 15;
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Введено неправильні вхідні дані!");
            }
        }
        private void EventNotifier_NewOrderEvent(object sender, EventArgs e)
        {
            // Логіка широкомовного івенту
            MessageBox.Show("Виявлено нове замовлення!", "Увага!");
        }
    }
}
