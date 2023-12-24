using DotNETCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNETCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.userName = txtUserName.Text;
            user.password = txtPassword.Text;
            user.age = 27;
            user.job = "engineer";
            user.Login(DateTime.Now.ToString());

        }

    }
}
