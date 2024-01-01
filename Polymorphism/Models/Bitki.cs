using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Bitki : Canli
    {
        public override void NefesAl() //override ile virtual yazılmış bir metod ezilerek yeniden yazıldı.
        {
            System.Windows.Forms.MessageBox.Show("Fotosentez solunumu yap");
        }
    }
}
