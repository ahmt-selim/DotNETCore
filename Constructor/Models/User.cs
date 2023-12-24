using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Models
{
    public class User
    {
        public User(string _userName, string _password) // Classda Constructor oluşturmak.
        {
            userName = _userName;
            password = _password;
        }
        public User() // Bu şekidle boş da bırakılabilirdi.(Hiç tanımlanmazsa içi boş olarak kullanılır.
        {
        }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
