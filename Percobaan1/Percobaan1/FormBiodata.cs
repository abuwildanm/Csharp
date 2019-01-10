using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percobaan1
{
    public partial class FormBiodata : Form
    {
        public FormBiodata()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            tampilNIM.Text += "         : " + tbNIM.Text;
            tampilNama.Text += "        : " + tbNama.Text;
            tampilHobi.Text += "         : " + tbHobi.Text;
            tampilAlamat.Text += "      : " + tbAlamat.Text;
        }
    }
}
