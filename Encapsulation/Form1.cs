using Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.userName = txtUserName.Text;
            account.password = txtPassword.Text;
            MessageBox.Show($"Kullanıcı başarıyla oluşturuldu: {account.userName}");

        }
    }
}
