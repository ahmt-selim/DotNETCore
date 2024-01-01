using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Canli
    {
        public virtual void NefesAl() 
        // "virtual" olarak işaretlediğimiz bir metod, daha sonra miras alınan sınıflar içerisinde değiştirilebilir.
        {
            System.Windows.Forms.MessageBox.Show("Akciğer solunumu yap");
        }
    }
}
