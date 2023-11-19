using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1.Practice6
{
    internal class Worker : IBuild
    {
        public void BuildHouses(int count)
        {
            MessageBox.Show($"Робітник будує {count} будинків", "Робітник");
        }
    }
}
