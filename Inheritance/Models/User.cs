using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class User
    {
        public User(string _userName, string _password)
        {
            userName = _userName;
            password = _password;
            createdDate = DateTime.Now;
        }
        public string userName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string prhoneNumber { get; set; }
        public DateTime createdDate { get; set; }
    }
}
