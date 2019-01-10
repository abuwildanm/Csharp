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
    public partial class Bab2_Form1 : Form
    {
        public Bab2_Form1()
        {
            InitializeComponent();
        }

        private void tutupAplikasi(object sender, EventArgs e)
        {
            lbHalo.Text = "Tutup Aplikasi";
        }
    }
}
