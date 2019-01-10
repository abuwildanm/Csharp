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
    public partial class Bab1_Form5 : Form
    {
        public Bab1_Form5()
        {
            InitializeComponent();
        }

        private void btnGantiFont_Click(object sender, EventArgs e)
        {
            DialogResult pilihan = dlgFont.ShowDialog();
            if (pilihan == DialogResult.OK)
            {
                lblInfo.Font = dlgFont.Font;
                lblInfo.ForeColor = dlgFont.Color;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}