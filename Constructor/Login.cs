using Constructor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        User user = new User("AhmetSelim", "123");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName == user.userName && password == user.password)
            {
                Login login = new Login();
                login.Close();
                HomePage homePage = new HomePage(user);
                homePage.Show();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
            }
        }
    }
}
