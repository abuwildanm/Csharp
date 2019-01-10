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
    public partial class HalKasir : Form
    {
        public static string connectionInfo = "datasource=localhost; port=3306; username=root; password=root; database=dbcsharp; SslMode = none";
        public static MySqlConnection connection = new MySqlConnection(connectionInfo);
        int tempJumlah, tran;

        public HalKasir()
        {
            InitializeComponent();
        }

        public void loadDataBarang()
        {
            //string query = "SELECT Kode_Barang, Nama, Stok, Harga FROM barang";
            string query = "SELECT Kode_Barang, Nama, Stok, Harga, kb.Kategori, kb.Jenis FROM barang as b JOIN kategoribarang as kb on b.ID_Kategori = kb.ID_Kategori ";

            try
            {
                //Inisialisasi Command
                MySqlCommand command = connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Masukkan data ke datagrid
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dgvBarang.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadDataTransaksi()
        {
            string query = "SELECT * FROM transaksi";

            try
            {
                //Inisialisasi Command
                MySqlCommand command = connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Masukkan data ke datagrid
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dgvTransaksi.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tambahTransaksi()
        {
            string query = "insert into transaksi(Kode_Transaksi, Kode_Barang, Nama_Barang, Harga, Jumlah, Total) values (@kodeTran, @kodeBarang, @nama, @harga, @jumlah, @total)";
            string tulisan = "";

            if ((dgvTransaksi.Rows.Count-1) == 0) //cek apakah tabel transaksi kosong?
            {
                tran = 0;
                tulisan = "TRAN00";
            }
            else
            {
                int last = dgvTransaksi.Rows.Count - 2; //ambil indeks terakhir tabel
                string kodeTran = dgvTransaksi.Rows[last].Cells[0].Value.ToString();

                if (tran < 9)
                {
                    tran = Int32.Parse(kodeTran[6].ToString());
                    tulisan = "TRAN00";
                }
                else
                {
                    tran = Int32.Parse(kodeTran.Substring(5, 2));
                    tulisan = "TRAN0";
                }
            }
            

            try
            {
                //Inisialisasi Command
                MySqlCommand command = connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@kodeTran", (tulisan + (++tran) + "-" + tbKodeBarang.Text));
                command.Parameters.AddWithValue("@kodeBarang", tbKodeBarang.Text);
                command.Parameters.AddWithValue("@nama", tbNamaBarang.Text);
                command.Parameters.AddWithValue("@harga", tbHarga.Text);
                command.Parameters.AddWithValue("@jumlah", tbJumlah.Text);
                command.Parameters.AddWithValue("@total", tbTotal.Text);

                //Eksekusi Query
                command.ExecuteNonQuery();

                //Default Form
                tbKodeBarang.Text = "Kode Barang";
                tbNamaBarang.Text = "Nama Barang";
                tbHarga.Text = "Harga";
                tbJumlah.Text = "Jumlah";
                tbTotal.Text = "Total";

                //Load Transaksi ke Datagrid
                loadDataTransaksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
        }

        public void hapusTransaksi()
        {
            string query = "DELETE FROM transaksi";

            try
            {
                //Inisialisasi Command
                MySqlCommand command = connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Eksekusi Query
                command.ExecuteNonQuery();

                //Pesan Berhasil
                MessageBox.Show("Transaksi Berhasil!");

                //Load Transaksi ke Datagrid
                loadDataTransaksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void search()
        {
            string query = "SELECT * FROM barang WHERE Nama like '%" + tbSearch.Text + "%'";

            try
            {
                //Inisialisasi Command
                MySqlCommand command = connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Masukkan data ke datagrid
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dgvBarang.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==================== Event Handler ====================

        private void HalamanAwal_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                loadDataBarang();
                loadDataTransaksi();
                connection.Close();
                navigasi.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbKodeBarang.Text = dgvBarang.SelectedRows[0].Cells[0].Value.ToString();
                tbNamaBarang.Text = dgvBarang.SelectedRows[0].Cells[1].Value.ToString();
                tbHarga.Text = dgvBarang.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int harga = Int32.Parse(tbHarga.Text);
                int jumlah = Int32.Parse(tbJumlah.Text);
                tempJumlah = jumlah;

                int total = harga * jumlah;
                tbTotal.Text = total.ToString();
            }
        }

        private void tbJumlah_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbJumlah.Text = tempJumlah.ToString();
            }
        }

        private void lblBeli_Click(object sender, EventArgs e)
        {
            try
            {
                int last = dgvTransaksi.Rows.Count - 2; //ambil indeks terakhir tabel
                int totalBelanja = 0;
                for (int i = 0; i <= last; i++)
                {
                    int total = Int32.Parse(dgvTransaksi.Rows[i].Cells[5].Value.ToString());
                    totalBelanja += total;
                }
                tbBelanja.Text = ("Rp. " + totalBelanja.ToString());

                connection.Open();
                hapusTransaksi();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {
            /*if (!tbJumlah.Text.Equals(""))
            {
                int harga = Int32.Parse(tbHarga.Text);
                int jumlah = Int32.Parse(tbJumlah.Text);
                tempJumlah = jumlah;

                int total = harga * jumlah;
                tbTotal.Text = total.ToString();
            }*/
        }

        private void navOpen_Click(object sender, EventArgs e)
        {
            navigasi.Show();
        }

        private void navClose_Click(object sender, EventArgs e)
        {
            navigasi.Hide();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            HalInput halInput = new HalInput(dgvBarang);
            DialogResult dialogResult = halInput.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                loadDataBarang();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HalUpdate halUpdate = new HalUpdate(dgvBarang);
            DialogResult dialogResult = halUpdate.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                loadDataBarang();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HalDelete halDelete = new HalDelete(dgvBarang);
            DialogResult dialogResult = halDelete.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                loadDataBarang();
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    connection.Open();
                    search();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblTambah_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                tambahTransaksi();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
