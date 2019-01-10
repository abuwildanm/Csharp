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

namespace WindowsFormsApp3
{
    public partial class HalUpdate : Form
    {
        MySqlConnection connection = HalKasir.connection;

        public HalUpdate()
        {
            InitializeComponent();
        }

        public HalUpdate(DataGridView dgv)
        {
            InitializeComponent();
            tbKodeBarang.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            tbNamaBarang.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            tbStok.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            tbHarga.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
        }

        public void update()
        {
            string query = "UPDATE barang SET Kode_Barang = @kode, Nama = @nama, Stok = @stok, Harga = @harga, ID_Kategori = @kategori WHERE Kode_Barang = @kode";

            try
            {
                //Inisialisasi Command
                MySqlCommand command = connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                string kategori = tbKodeBarang.Text.Substring(0, 7);
                command.Parameters.AddWithValue("@kode", tbKodeBarang.Text);
                command.Parameters.AddWithValue("@nama", tbNamaBarang.Text);
                command.Parameters.AddWithValue("@stok", tbStok.Text);
                command.Parameters.AddWithValue("@harga", tbHarga.Text);
                command.Parameters.AddWithValue("@kategori", kategori);

                //Eksekusi Query
                command.ExecuteNonQuery();

                //Pesan Berhasil
                MessageBox.Show("Data Berhasil Diubah!");

                //Kosongkan Form
                tbKodeBarang.Text = "Kode Barang";
                tbNamaBarang.Text = "Nama Barang";
                tbStok.Text = "Stok";
                tbHarga.Text = "Harga";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblUpdateSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                update();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
