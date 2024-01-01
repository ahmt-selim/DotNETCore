using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass.Tools
{
    public class Tank : SavasAraci
    {
        public override void Saldir() //Miras alınan sınıftan alınan metot override edilir yani ezilir.
        {
            MessageBox.Show("Tank ile saldırıldı.");
        }
    }
}
