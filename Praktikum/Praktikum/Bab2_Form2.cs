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
    public partial class Bab2_Form2 : Form
    {
        public Bab2_Form2()
        {
            InitializeComponent();
        }

        private void textBox_EnabledChanged(object sender, EventArgs e)
        {
            if (textBox.Enabled) { label.Text = "TextBox Enable"; }
            else { label.Text = "TextBox Disable"; }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            label.Text = "TextBox Enter";
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            label.Text = "TextBox Leave";
        }

        private void textBox_VisibleChanged(object sender, EventArgs e)
        {
            if (textBox.Visible) { label.Text = "TextBox Visible"; }
            else { label.Text = "TextBox Unvisible"; }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            textBox.Enabled = !textBox.Enabled;
            if (textBox.Enabled) { btnEnable.Text = "Disable"; }
            else { btnEnable.Text = "Enable"; }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            textBox.Visible = !textBox.Visible;
            if (textBox.Visible) { btnVisible.Text = "Unvisible"; }
            else { btnVisible.Text = "Visible"; }
        }
    }
}