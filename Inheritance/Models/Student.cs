﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Student : User
    {
        public Student(string _schoolNumber, string _userName, string _password) : base(_userName, _password)
        {
            schoolNumber = _schoolNumber;
        }

        public ClassRoom classRoom { get; set; }
        public string schoolNumber { get; set; }
        public Teacher[] teachers { get; set; }
        public List<Lesson> lessons { get; set; }
        public void DoHomework()
        {
            System.Windows.Forms.MessageBox.Show("Ödev Yapılıyor.");
        }
        public void GetFullName()
        {

        }
    }
}
