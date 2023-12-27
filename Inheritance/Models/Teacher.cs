using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Teacher : User
    {
        public Teacher(string _userName, string _password) : base(_userName, _password)
        {

        }

        public List<ClassRoom> classrooms { get; set; }
        public string branch { get; set; }
        public void GiveHomeWork()
        {
            System.Windows.Forms.MessageBox.Show("Ödev verildi.");
        }
    }
}
