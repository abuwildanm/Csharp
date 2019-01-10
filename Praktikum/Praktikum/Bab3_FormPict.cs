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
    public partial class Bab3_FormPict : Form
    {
        int deg, n;
        Image gbrAsli;
        Bab3_Form1 FrmParent;

        public Bab3_FormPict(Bab3_Form1 F1)
        {
            InitializeComponent();
            FrmParent = F1;
        }

        public void setPic(Image img)
        {
            pictureBox1.Image = img;
            gbrAsli = pictureBox1.Image;
        }

        public void PutarKanan()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            deg += 90;
            if (deg > 360) { deg -= 360; }
            pictureBox1.Image = flipImage;
            textBox1.Text = deg.ToString();
        }

        public void PutarKiri()
        {
            Image flipImage = pictureBox1.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            deg -= 90;
            if (deg < 0) { deg = 270; }
            pictureBox1.Image = flipImage;
            textBox1.Text = deg.ToString();
        }

        public void Perbesar()
        {
            pictureBox1.Width += 50;
            pictureBox1.Height += 50;
            textBox1.Text = pictureBox1.Width + ";" + pictureBox1.Height;
        }

        public void Perkecil()
        {
            pictureBox1.Width -= 50;
            pictureBox1.Height -= 50;
            textBox1.Text = pictureBox1.Width + ";" + pictureBox1.Height;
        }

        private void btnSetDegreeAll_Click(object sender, EventArgs e)
        {
            FrmParent.AllDegree1 = deg;
        }

        private void btnApplyDegree_Click(object sender, EventArgs e)
        {
            int a1, a2;
            //untuk ambil deg dari parent dibagi 90
            a1 = FrmParent.AllDegree1 / 90;
            a2 = deg / 90;

            //jika rotasi gbr kurang dari induk, maka putar kanan
            if (a2 < a1)
            {
                for (int i = a2; i < a1; i++)
                {
                    PutarKanan();
                }
            }
            else if (a2 > a1)
            {
                for (int i = a1; i < a2; i++)
                {
                    PutarKiri();
                }
            }
        }

        private void btnAturZoom_Click(object sender, EventArgs e)
        {
            FrmParent.size1 = pictureBox1.Width.ToString() + ";" + pictureBox1.Height.ToString();
        }

        private void btnApplyZoom_Click(object sender, EventArgs e)
        {
            //size = "width;height"
            string[] size = FrmParent.size1.Split(';');
            pictureBox1.Width = Convert.ToInt32(size[0]);
            pictureBox1.Height = Convert.ToInt32(size[1]);
            textBox1.Text = pictureBox1.Width + ";" + pictureBox1.Height;
        }
    }
}