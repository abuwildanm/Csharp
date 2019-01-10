using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Logika_Fuzzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkanSeg_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(tbAwalSeg.Text);
                double b = Convert.ToDouble(tbTengahSeg.Text);
                double c = Convert.ToDouble(tbAkhirSeg.Text);
                double alpha = Convert.ToDouble(tbAlphaSeg.Text);
                var pointsM = chartSeg.Series["Membership"].Points;
                var pointsA = chartSeg.Series["Alpha"].Points;

                if (0 < alpha && alpha <= 1)
                {
                    foreach (var series in chartSeg.Series)
                    {
                        series.Points.Clear();
                    }

                    for (double x = 0; x <= 10; x += 0.01)
                    {
                        if (a <= x && x <= b)
                        {
                            pointsM.AddXY(x, (x - a) / (b - a));
                        }
                        else if (b <= x && x <= c)
                        {
                            pointsM.AddXY(x, (x - c) / (b - c));
                        }
                        else
                        {
                            pointsM.AddXY(x, 0);
                        }
                        pointsA.AddXY(x, alpha);
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungSeg_Click(object sender, EventArgs e)
        {
            try
            {
                double alpha = Convert.ToDouble(tbAlphaSeg.Text);
                var pointsM = chartSeg.Series["Membership"].Points;
                int jumlahPoint = pointsM.Count;
                List<double> listNilaiX = new List<double>();

                if (0 < alpha && alpha <= 1)
                {
                    //Proses pencarian titik yang berpotongan dengan alpha
                    for (int i = 0; i < jumlahPoint; i++)
                    {
                        double nilaiX = pointsM[i].XValue;
                        double pembulatanNilaiX = Math.Round(nilaiX, 2);
                        double nilaiY = pointsM[i].YValues[0];
                        double pembulatanNilaiY = Math.Round(nilaiY, 2);
                        if (pembulatanNilaiY == alpha) { listNilaiX.Add(pembulatanNilaiX); }
                    }

                    //Proses menampilkan hasil
                    if (listNilaiX.Count > 1)
                    {
                        tbX1Seg.Text = listNilaiX[0].ToString();
                        tbX2Seg.Text = listNilaiX[1].ToString();
                    }
                    else
                    {
                        tbX1Seg.Text = listNilaiX[0].ToString();
                        tbX2Seg.Text = listNilaiX[0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTampilkanTrap_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(tbAwalTrap.Text);
                double b = Convert.ToDouble(tbTengah1Trap.Text);
                double c = Convert.ToDouble(tbTengah2Trap.Text);
                double d = Convert.ToDouble(tbAkhirTrap.Text);
                double alpha = Convert.ToDouble(tbAlphaTrap.Text);

                if (0 < alpha && alpha <= 1)
                {
                    foreach (var series in chartTrap.Series)
                    {
                        series.Points.Clear();
                    }

                    for (double x = 0; x <= 10; x += 0.01)
                    {
                        if (a <= x && x <= b)
                        {
                            chartTrap.Series["Membership"].Points.AddXY(x, (x - a) / (b - a));
                        }
                        else if (b <= x && x <= c)
                        {
                            chartTrap.Series["Membership"].Points.AddXY(x, 1);
                        }
                        else if (c <= x && x <= d)
                        {
                            chartTrap.Series["Membership"].Points.AddXY(x, (x - d) / (c - d));
                        }
                        else
                        {
                            chartTrap.Series["Membership"].Points.AddXY(x, 0);
                        }
                        chartTrap.Series["Alpha"].Points.AddXY(x, alpha);
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungTrap_Click(object sender, EventArgs e)
        {
            try
            {
                double alpha = Convert.ToDouble(tbAlphaTrap.Text);
                var pointsM = chartTrap.Series["Membership"].Points;
                int jumlahPoint = pointsM.Count;
                List<double> listNilaiX = new List<double>();

                if (0 < alpha && alpha <= 1)
                {
                    //Proses pencarian titik yang berpotongan dengan alpha
                    for (int i = 0; i < jumlahPoint; i++)
                    {
                        double nilaiX = pointsM[i].XValue;
                        double pembulatanNilaiX = Math.Round(nilaiX, 2);
                        double nilaiY = pointsM[i].YValues[0];
                        double pembulatanNilaiY = Math.Round(nilaiY, 2);
                        if (pembulatanNilaiY == alpha) { listNilaiX.Add(pembulatanNilaiX); }
                    }

                    //Proses menampilkan hasil
                    if (listNilaiX.Count > 2)
                    {
                        for (int i = 0; i < listNilaiX.Count; i++)
                        {
                            tbX1Trap.Text += listNilaiX[i] + "; ";
                            tbX2Trap.Text += listNilaiX[i] + "; ";
                        }
                    }
                    else if (listNilaiX.Count > 1)
                    {
                        tbX1Trap.Text = listNilaiX[0].ToString();
                        tbX2Trap.Text = listNilaiX[1].ToString();
                    }
                    else
                    {
                        tbX1Trap.Text = listNilaiX[0].ToString();
                        tbX2Trap.Text = listNilaiX[0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTampilkanGauss_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(tbPuncakGauss.Text);
                double b = Convert.ToDouble(tbLebarGauss.Text);
                double alpha = Convert.ToDouble(tbAlphaGauss.Text);

                if (0 < alpha && alpha <= 1)
                {
                    foreach (var series in chartGauss.Series)
                    {
                        series.Points.Clear();
                    }

                    for (double x = 0; x <= 10; x += 0.01)
                    {
                        chartGauss.Series["Membership"].Points.AddXY(x, Math.Pow(Math.E, 0-Math.Pow((x-a)/b, 2)));
                        chartGauss.Series["Alpha"].Points.AddXY(x, alpha);
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungGauss_Click(object sender, EventArgs e)
        {
            try
            {
                double alpha = Convert.ToDouble(tbAlphaGauss.Text);
                var pointsM = chartGauss.Series["Membership"].Points;
                int jumlahPoint = pointsM.Count;
                List<double> listNilaiX = new List<double>();

                if (0 < alpha && alpha <= 1)
                {
                    //Proses pencarian titik yang berpotongan dengan alpha
                    for (int i = 0; i < jumlahPoint; i++)
                    {
                        double nilaiX = pointsM[i].XValue;
                        double pembulatanNilaiX = Math.Round(nilaiX, 2);
                        double nilaiY = pointsM[i].YValues[0];
                        double pembulatanNilaiY = Math.Round(nilaiY, 2);
                        if (pembulatanNilaiY == alpha) { listNilaiX.Add(pembulatanNilaiX); }
                    }

                    //Proses menampilkan hasil
                    if (listNilaiX.Count > 2)
                    {
                        for (int i = 0; i < listNilaiX.Count; i++)
                        {
                            tbX1Gauss.Text += listNilaiX[i] + "; ";
                            tbX2Gauss.Text += listNilaiX[i] + "; ";
                        }
                    }
                    else if (listNilaiX.Count > 1)
                    {
                        tbX1Gauss.Text = listNilaiX[0].ToString();
                        tbX2Gauss.Text = listNilaiX[1].ToString();
                    }
                    else
                    {
                        tbX1Gauss.Text = listNilaiX[0].ToString();
                        tbX2Gauss.Text = listNilaiX[0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTampilkanCauchy_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(tbPuncakCauchy.Text);
                double b = Convert.ToDouble(tbLebarCauchy.Text);
                double c = Convert.ToDouble(tbCCauchy.Text);
                double alpha = Convert.ToDouble(tbAlphaCauchy.Text);

                if (0 < alpha && alpha <= 1)
                {
                    foreach (var series in chartCauchy.Series)
                    {
                        series.Points.Clear();
                    }

                    for (double x = 0; x <= 10; x += 0.01)
                    {
                        chartCauchy.Series["Membership"].Points.AddXY(x, 1 / (1 + Math.Pow(Math.Abs((x-a)/b), 2 * c)));
                        chartCauchy.Series["Alpha"].Points.AddXY(x, alpha);
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungCauchy_Click(object sender, EventArgs e)
        {
            try
            {
                double alpha = Convert.ToDouble(tbAlphaCauchy.Text);
                var pointsM = chartCauchy.Series["Membership"].Points;
                int jumlahPoint = pointsM.Count;
                List<double> listNilaiX = new List<double>();

                if (0 < alpha && alpha <= 1)
                {
                    //Proses pencarian titik yang berpotongan dengan alpha
                    for (int i = 0; i < jumlahPoint; i++)
                    {
                        double nilaiX = pointsM[i].XValue;
                        double pembulatanNilaiX = Math.Round(nilaiX, 2);
                        double nilaiY = pointsM[i].YValues[0];
                        double pembulatanNilaiY = Math.Round(nilaiY, 2);
                        if (pembulatanNilaiY == alpha) { listNilaiX.Add(pembulatanNilaiX); }
                    }

                    //Proses menampilkan hasil
                    if (listNilaiX.Count > 2)
                    {
                        for (int i = 0; i < listNilaiX.Count; i++)
                        {
                            tbX1Cauchy.Text += listNilaiX[i] + "; ";
                            tbX2Cauchy.Text += listNilaiX[i] + "; ";
                        }
                    }
                    else if (listNilaiX.Count > 1)
                    {
                        tbX1Cauchy.Text = listNilaiX[0].ToString();
                        tbX2Cauchy.Text = listNilaiX[1].ToString();
                    }
                    else
                    {
                        tbX1Cauchy.Text = listNilaiX[0].ToString();
                        tbX2Cauchy.Text = listNilaiX[0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTampilkanSig_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(tbArahTerbukaSig.Text);
                double b = Convert.ToDouble(tbTengahSig.Text);
                double alpha = Convert.ToDouble(tbAlphaSig.Text);

                if (0 < alpha && alpha <= 1)
                {
                    foreach (var series in chartSig.Series)
                    {
                        series.Points.Clear();
                    }

                    for (double x = 0; x <= 10; x += 0.01)
                    {
                        chartSig.Series["Membership"].Points.AddXY(x, 1 / (1 + Math.Pow(Math.E, (0-a) * (x-b))));
                        chartSig.Series["Alpha"].Points.AddXY(x, alpha);
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungSig_Click(object sender, EventArgs e)
        {
            try
            {
                double alpha = Convert.ToDouble(tbAlphaSig.Text);
                var pointsM = chartSig.Series["Membership"].Points;
                int jumlahPoint = pointsM.Count;
                List<double> listNilaiX = new List<double>();

                if (0 < alpha && alpha <= 1)
                {
                    //Proses pencarian titik yang berpotongan dengan alpha
                    for (int i = 0; i < jumlahPoint; i++)
                    {
                        double nilaiX = pointsM[i].XValue;
                        double pembulatanNilaiX = Math.Round(nilaiX, 2);
                        double nilaiY = pointsM[i].YValues[0];
                        double pembulatanNilaiY = Math.Round(nilaiY, 2);
                        if (pembulatanNilaiY == alpha) { listNilaiX.Add(pembulatanNilaiX); }
                    }

                    //Proses menampilkan hasil
                    if (listNilaiX.Count > 2)
                    {
                        for (int i = 0; i < listNilaiX.Count; i++)
                        {
                            tbX1Sig.Text += listNilaiX[i] + "; ";
                            tbX2Sig.Text += listNilaiX[i] + "; ";
                        }
                    }
                    else if (listNilaiX.Count > 1)
                    {
                        tbX1Sig.Text = listNilaiX[0].ToString();
                        tbX2Sig.Text = listNilaiX[1].ToString();
                    }
                    else
                    {
                        tbX1Sig.Text = listNilaiX[0].ToString();
                        tbX2Sig.Text = listNilaiX[0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nilai alpha harus diantara 0 s.d. 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
