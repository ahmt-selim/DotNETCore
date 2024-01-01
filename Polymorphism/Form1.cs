using Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Insan insan = new Insan();
        Hayvan hayvan = new Hayvan();
        Bitki bitki = new Bitki();
        private void btnInsan_Click(object sender, EventArgs e)
        {
            insan.NefesAl();
        }

        private void btnHayvan_Click(object sender, EventArgs e)
        {
            hayvan.NefesAl();
        }

        private void btnBitki_Click(object sender, EventArgs e)
        {
            bitki.NefesAl();
        }
    }
}
