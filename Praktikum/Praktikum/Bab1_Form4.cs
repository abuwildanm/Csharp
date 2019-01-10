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
    public partial class Bab1_Form4 : Form
    {
        public Bab1_Form4()
        {
            InitializeComponent();
        }

        private void btnGanti_Click(object sender, EventArgs e)
        {
            DialogResult pilihan = dlgWarna.ShowDialog();
            if (pilihan == DialogResult.OK)
            {
                this.BackColor = dlgWarna.Color;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}