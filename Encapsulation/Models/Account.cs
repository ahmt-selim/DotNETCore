using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation.Models
{
    public class Account
    {
        public Account() // Consructor
        {
            int a = 5; //local veriable: Bu değişken sadece burada kullanılır

        }
        int b = 5; // field (Global değişken)

        string _userName;

        public string userName
        {
            get { return _userName; } //sürekli kendini dönememesi için farklı bir değişken atadık
            set
            {
                if (value.Length > 3)
                {
                    _userName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Lütfen 3 karakterden fazla giriniz.");
                    Application.Restart();
                }
            } 
        }//Encapsulation: Kapsülleme işlemi.
        public string password { get; set; }
    }
}
