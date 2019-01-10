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
    public partial class Bab1_Form6 : Form
    {
        public Bab1_Form6()
        {
            InitializeComponent();
        }

        private void btnBukaFile_Click(object sender, EventArgs e)
        {
            DialogResult pilihan = dlgBukaFile.ShowDialog();
            if (pilihan == DialogResult.OK)
            {
                tbNamaFile.Text = dlgBukaFile.FileName;
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}