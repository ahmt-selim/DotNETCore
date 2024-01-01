using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass.Tools
{
    public class Gemi : SavasAraci
    {
        public override void Saldir()
        {
            MessageBox.Show("Gemi ile saldırıldı.");
        }
    }
}
