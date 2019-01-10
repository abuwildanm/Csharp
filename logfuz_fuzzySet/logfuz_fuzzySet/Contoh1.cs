using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logika_Fuzzy
{
    public partial class Contoh1 : Form
    {
        public Contoh1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var point = chart1.Series[0].Points[2].YValues[0];
            MessageBox.Show(point.ToString());
        }
    }
}
