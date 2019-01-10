using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Si_Indang
{
    public partial class FormUtama : Form
    {
        public static Controller controller;

        public FormUtama()
        {
            InitializeComponent();
            controller = new Controller();
        }

        public void FormUtama_Load(object sender, EventArgs e)
        {
            controller.tampilBarang(dataGrid);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            controller.tampilBarang(dataGrid);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            //Biar datanya ke-load otomatis
            FormTambah formTambah = new FormTambah(dataGrid);
            DialogResult dialogResult = formTambah.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                controller.tampilBarang(dataGrid);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //Biar bisa ngambil nilai di datagrid
            FormHapus formHapus = new FormHapus(dataGrid);

            //Biar datanya ke-load otomatis
            DialogResult dialogResult = formHapus.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                controller.tampilBarang(dataGrid);
            }
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            //Biar bisa ngambil nilai di datagrid
            FormPerbarui formPerbarui = new FormPerbarui(dataGrid);

            //Biar datanya ke-load otomatis
            DialogResult dialogResult = formPerbarui.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                controller.tampilBarang(dataGrid);
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                controller.cariBarang(dataGrid, tbSearch.Text);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.saringBarang(dataGrid, cbFilter.SelectedItem.ToString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            button.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = System.Drawing.Color.SteelBlue;
        }
    }
}
