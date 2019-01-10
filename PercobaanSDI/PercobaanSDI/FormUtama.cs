using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercobaanSDI
{
    public partial class FormUtama : Form
    {
        private Form1 form1 = new Form1();
        private Form2 form2 = new Form2();

        private String str; //s kecil
        public string Str //S besar
        {
            get { return str; }
            set { str = value; }
        }
        public static Form3 form3;
        public static Form4 form4;

        public FormUtama()
        {
            InitializeComponent();
            form3 = new Form3(this);
            form3.MdiParent = this;
            form4 = new Form4(this);
            form4.MdiParent = this;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1 != null) form1.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1 != null) form1.Hide();
        }

        private void maximisedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1 != null) {
                form1.WindowState = FormWindowState.Maximized;
                form1.Show();
            }
        }

        private void minimisedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1 != null) form1.WindowState = FormWindowState.Minimized;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (form1 != null) form1.Text = toolStripTextBox1.Text;
        }

        private void showToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form3.MdiParent = this;
            if (form3 != null) form3.Show();
        }

        private void hideToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form3.MdiParent = this;
            if (form3 != null) form3.Hide();
        }

        private void maximisedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form3.MdiParent = this;
            if (form3 != null)
            {
                form3.WindowState = FormWindowState.Maximized;
                form3.Show();
            }
        }

        private void minimisedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form3.MdiParent = this;
            if (form3 != null) form3.WindowState = FormWindowState.Minimized;
        }

        private void showToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            form4 = new Form4(this);
            form4.MdiParent = this;
            if (form4 != null) form4.Show();
        }
    }
}
