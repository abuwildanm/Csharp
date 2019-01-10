using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Login
{
    public partial class FormLogin : Form
    {
        HalamanUtama halUtama = new HalamanUtama();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Harusganteng" && tbPassword.Text == "12345")
            {
                MessageBox.Show("Username dan Password anda benar! Silahkan masuk...");
                this.Hide();
                halUtama.MdiParent = this.MdiParent;
                halUtama.WindowState = FormWindowState.Maximized;
                halUtama.Show();
            } else
            {
                MessageBox.Show("Username atau Password anda salah!");
            }
        }
    }
}
