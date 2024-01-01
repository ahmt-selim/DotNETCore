using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass.Tools
{
    public class Ucak : SavasAraci
    {
        public override void Saldir()
        {
            MessageBox.Show("Uçak ile saldırıdı.");
        }
    }
}
