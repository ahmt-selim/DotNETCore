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
    public partial class HomePage : Form
    {
        public HomePage(User _user) //Formun Constructorına girdi vermek
        {
            InitializeComponent();
            user = _user;
        }
        User user;
        private void HomePage_Load(object sender, EventArgs e)
        {
            lblMessage.Text = $"Hoşgeldiniz {user.userName}";
        }
    }
}
