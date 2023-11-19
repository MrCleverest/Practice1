using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1.Practice6
{
    internal class HR : IHire
    {
        public string HireEmployee()
        {
            return "Наймаєм нового співробітника.";
        }

        public void HREvent()
        {
            MessageBox.Show(HireEmployee(), "Кадри");
        }
    }
}
