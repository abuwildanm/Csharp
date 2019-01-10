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
    public partial class Bab2_Form4 : Form
    {
        bool enterTb1, enterTb2;

        public Bab2_Form4()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Button btnInput = (Button)sender;

            if (btnInput.Text == "C") {
                tbAngka1.Text = "";
                tbAngka2.Text = "";
            }
            else if (enterTb1) {
                tbAngka1.Text += btnInput.Text;
            }
            else if (enterTb2) {
                tbAngka2.Text += btnInput.Text;
            }
        }

        private void btnOperasi_Click(object sender, EventArgs e)
        {
            double angka1, angka2, hasil;
            Button btnOperasi = (Button)sender;

            // Convert string to double
            Double.TryParse(tbAngka1.Text, out angka1);
            Double.TryParse(tbAngka2.Text, out angka2);

            if (btnOperasi.Text == "+") {
                hasil = angka1 + angka2;
                lblHasil.Text = hasil.ToString();
            }
            else if (btnOperasi.Text == "-") {
                hasil = angka1 - angka2;
                lblHasil.Text = hasil.ToString();
            }
            else if (btnOperasi.Text == "*") {
                hasil = angka1 * angka2;
                lblHasil.Text = hasil.ToString();
            }
            else if (btnOperasi.Text == "/") {
                hasil = angka1 / angka2;
                lblHasil.Text = hasil.ToString();
            }
        }

        private void tbAngka1_Enter(object sender, EventArgs e)
        {
            enterTb1 = true;
            enterTb2 = false;
        }

        private void tbAngka2_Enter(object sender, EventArgs e)
        {
            enterTb1 = false;
            enterTb2 = true;
        }
    }
}