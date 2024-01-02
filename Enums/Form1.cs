using Enums.Enums;
using Enums.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.userName = txtUserName.Text;
            game.difficulty = (Difficulty)cmbDiff.SelectedItem;
            game.gender = radioMan.Checked ? Gender.Male : Gender.Female;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDiff.Items.Add(Difficulty.Easy);
            cmbDiff.Items.Add(Difficulty.Medium); 
            cmbDiff.Items.Add(Difficulty.Hard);


        }
    }
}
