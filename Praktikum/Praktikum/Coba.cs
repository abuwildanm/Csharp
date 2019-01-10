using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum
{
    public partial class Coba : Form
    {
        public Coba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = sender.ToString() + " " + e.ToString();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse enter nih";
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Mouse hover nih";
        }
    }
}
