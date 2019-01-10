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
    public partial class FormUtama : Form
    {
        //FormStart start = new FormStart();
        FormLogin login = new FormLogin();

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            //start.MdiParent = this;
            //start.WindowState = FormWindowState.Maximized;
            //start.Show();

            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }
    }
}
