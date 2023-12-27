using Inheritance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.number = "1";
            classRoom.character = "A";

            Teacher teacher = new Teacher("Selim", "435"); 

            Student student = new Student("144", "Ahmet", "123");
            student.classRoom = classRoom;
            student.teachers[0] = teacher;
        }
    }
}
