using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Si_Indang
{
    public partial class FormPerbarui : Form
    {
        public Controller controller;

        public FormPerbarui()
        {
            InitializeComponent();
            controller = FormUtama.controller;
        }

        public FormPerbarui(DataGridView dataGridView)
        {
            InitializeComponent();
            tbKode.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            tbNama.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            tbHarga.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            tbStok.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            controller = FormUtama.controller;
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            String kode = tbKode.Text;
            String nama = tbNama.Text;
            int harga = Convert.ToInt32(tbHarga.Text);
            int stok = Convert.ToInt32(tbStok.Text);
            String kategori = tbKode.Text.Substring(0, 3);

            controller.perbaruiBarang(kode, nama, harga, stok, kategori);

            //Kosongkan Form
            tbKode.Text = "";
            tbNama.Text = "";
            tbHarga.Text = "";
            tbStok.Text = "";

            this.DialogResult = DialogResult.OK;
        }
    }
}
