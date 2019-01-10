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
    public partial class FormStart : Form
    {
        FormLogin login = new FormLogin();

        public FormStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.MdiParent = this.MdiParent;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Highlight;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ActiveCaption;
        }
    }
}
