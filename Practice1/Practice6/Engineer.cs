using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1.Practice6
{
    internal class Engineer : IProject, IRun
    {
        public void StartProject()
        {
            MessageBox.Show("Розпочато новий проект");
        }

        public string Run()
        {
            return "Інженер виїхав на об'єкт.";
        }

        public void EngineerEvent()
        {
            MessageBox.Show(Run(), "Інженер");
        }
    }
}
