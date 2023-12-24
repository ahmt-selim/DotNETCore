using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNETCore.Models
{
    class User
    {
        public string userName { get; set; }
        public string password { set; get; }
        public int age { set; get; }
        public string job { set; get; }
        public void Login(string loginDate)
        {
            MessageBox.Show($"{loginDate} tarihinde {userName} adlı kullanıcı giriş yaptı.");
        }
    }
}
