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
    public partial class Bab2_Form3 : Form
    {
        public Bab2_Form3()
        {
            InitializeComponent();
        }

        //No. 1 & No. 2
        private void Bab2_Form3_MouseClick(object sender, MouseEventArgs e)
        {
            labelMouse.Text += "\nTombol : " + e.Button + ", Jumlah klik : " + e.Clicks;
        }

        //No. 3
        private void Bab2_Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) {
                labelKeyboard.Text += "\nTombol : " + e.KeyData + "; Keterangan : Memilih semua";
            }

            if (e.Control && e.KeyCode == Keys.C) {
                labelKeyboard.Text += "\nTombol : " + e.KeyData + "; Keterangan : Melakukan Salin Data";
            }

            if (e.Control && e.KeyCode == Keys.V) {
                labelKeyboard.Text += "\nTombol : " + e.KeyData + "; Keterangan : Melakukan Tempel Data";
            }

            if (e.Control && e.KeyCode == Keys.P) {
                labelKeyboard.Text += "\nTombol : " + e.KeyData + "; Keterangan : Melakukan Cetak";
            }
        }
    }
}