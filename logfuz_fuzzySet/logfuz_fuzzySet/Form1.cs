using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logfuz_fuzzySet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Jenis.Items.Add("Trapesium");
            Jenis.Items.Add("Segitiga");
            labeltitik.Hide();
            labelInterval.Hide();
            A.Hide();
            B.Hide();
            C.Hide();
            D.Hide();
            labela.Hide();
            labelb.Hide();
            labelc.Hide();
            labeld.Hide();
            Submit.Hide();
            alpha_cut.Hide();
            labelAlpha.Hide();
            chart1.Hide();
            x.Hide();
            labelx.Hide();
            y.Hide();
            labely.Hide();
        }


            double a_i, b_i, c_i, d_i, x_i, y_i, alpha_cut_i;

        public class itemCombobox
        {
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            A.Show();
            B.Show();
            C.Show();
            labela.Show();
            labelb.Show();
            labelc.Show();
            Submit.Show();
            labelAlpha.Show();
            alpha_cut.Show();
            labeltitik.Show();
            if (Jenis.SelectedItem.ToString() == "Trapesium")
            {
                D.Show();
                labeld.Show();
                Submit.Show();
                labelAlpha.Show();
                alpha_cut.Show();
            }
            else if (Jenis.SelectedItem.ToString() == "Segitiga")
            {
               
                labeld.Hide();
                D.Hide();
            }
        }
        
        private void Submit_Click(object sender, EventArgs e)
        {
            labelInterval.Show();
            chart1.Show();
            x.Show();
            labelx.Show();
            y.Show();
            labely.Show();
            if (A.Text == "" && B.Text == "" && C.Text == "" && alpha_cut.Text == "")
            {
                MessageBox.Show("Harap semua titik dan aplha cut diisi");
            }
            else if (Jenis.SelectedItem.ToString() == "Trapesium" && D.Text == "")
            {
                MessageBox.Show("Harap semua titik dan aplha cut diisi");
            }
            else
            {

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                a_i = Double.Parse(A.Text);
                b_i = Double.Parse(B.Text);
                c_i = Double.Parse(C.Text);
                alpha_cut_i = Double.Parse(alpha_cut.Text);
                chart1.Series[1].Points.AddXY(a_i, 0);
                chart1.Series[1].Points.AddXY(b_i, 1);
                if (Jenis.SelectedItem.ToString() == "Trapesium")
                {
                    d_i = Double.Parse(D.Text);
                    chart1.Series[1].Points.AddXY(c_i, 1);
                    chart1.Series[1].Points.AddXY(d_i, 0);
                    chart1.Series[0].Points.AddXY(d_i + 1, alpha_cut_i);
                }
                else
                {
                    chart1.Series[1].Points.AddXY(c_i, 0);
                    chart1.Series[0].Points.AddXY(c_i + 1, alpha_cut_i);
                }
                chart1.Series[0].Points.AddXY(0, alpha_cut_i);
                if (alpha_cut_i == 1)
                {
                    x_i = 1;
                    y_i = 1;
                    x.Text = x_i.ToString("0.000000");
                    y.Text = y_i.ToString("0.000000");
                }
                else if (alpha_cut_i < 1 && alpha_cut_i > 0)
                {
                    x_i = (b_i - a_i) * alpha_cut_i + a_i;

                    if (Jenis.SelectedItem.ToString() == "Trapesium")
                    {
                        y_i = (c_i - d_i) * alpha_cut_i + d_i;
                    }
                    else if (Jenis.SelectedItem.ToString() == "Segitiga")
                    {
                        y_i = (b_i - c_i) * alpha_cut_i + c_i;
                    }
                    x.Text = x_i.ToString("0.000000");
                    y.Text = y_i.ToString("0.000000");
                }
                else
                {
                    MessageBox.Show("alpha cut harus bernilai 0 hingga 1");
                }
            }

        }
    }
}
