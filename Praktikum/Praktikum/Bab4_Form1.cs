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

namespace Praktikum
{
    public partial class Bab4_Form1 : Form
    {
        // Prepare the connection
        private static string connectionString = "server=localhost;port=3306;username=root;password=root;database=perpustakaan;Sslmode=none";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public Bab4_Form1()
        {
            InitializeComponent();
            loadDataBuku();
            loadDataPinjaman();
        }

        public void loadDataBuku()
        {
            listBuku.Items.Clear();
            string query = "SELECT * FROM data_buku";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void loadDataPinjaman()
        {
            listPinjaman.Items.Clear();
            string query = "SELECT p.Id_Pinjaman, b.Judul, m.Nama, p.Jumlah_Pinjaman, p.Status FROM data_pinjaman as p, data_buku as b, mahasiswa as m WHERE p.Id_Buku = b.Id_buku AND p.NIM = m.NIM";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_pinjaman"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah_pinjaman"].ToString());
                        listViewItem.SubItems.Add(reader["status"].ToString());
                        listPinjaman.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void searchBuku(string query)
        {
            listBuku.Items.Clear();
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void searchPinjaman(string query)
        {
            listPinjaman.Items.Clear();
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_pinjaman"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah_pinjaman"].ToString());
                        listViewItem.SubItems.Add(reader["status"].ToString());
                        listPinjaman.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void button_Tambah_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_buku (id_buku, judul, pengarang, jumlah) VALUES (@id, @judul, @pengarang, @jumlah)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                loadDataBuku();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_buku SET judul = @judul, pengarang = @pengarang, jumlah = @jumlah WHERE id_buku = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                loadDataBuku();
            }
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_buku WHERE id_buku = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                loadDataBuku();
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            listBuku.Items.Clear();
            string query = "SELECT * FROM data_buku";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        listViewItem.SubItems.Add(reader["pengarang"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void listBuku_Click(object sender, EventArgs e)
        {
            text_id.Text = listBuku.SelectedItems[0].SubItems[0].Text;
            text_judul.Text = listBuku.SelectedItems[0].SubItems[1].Text;
            text_pengarang.Text = listBuku.SelectedItems[0].SubItems[2].Text;
            text_jumlah.Text = listBuku.SelectedItems[0].SubItems[3].Text;
        }

        private void tbSearchBuku_KeyDown(object sender, KeyEventArgs e)
        {
            string itemTerpilih = cbFilterBuku.SelectedItem.ToString();
            string query;
            if (e.KeyCode == Keys.Enter)
            {
                if (itemTerpilih.Equals("Judul"))
                {
                    query = "SELECT * FROM data_buku WHERE Judul LIKE '%" + tbSearchBuku.Text + "%'";
                    searchBuku(query);
                }
                else if (itemTerpilih.Equals("Pengarang"))
                {
                    query = "SELECT * FROM data_buku WHERE Pengarang LIKE '%" + tbSearchBuku.Text + "%'";
                    searchBuku(query);
                }
            }
        }

        // === Data Peminjaman ===

        private void btnTambahPinjaman_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO data_pinjaman VALUES (@idPinjaman, @idBuku, @nim, @jumlah, @status)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@idPinjaman", tbIdPinjaman.Text);
                cmd.Parameters.AddWithValue("@idBuku", tbIdBuku.Text);
                cmd.Parameters.AddWithValue("@nim", tbNim.Text);
                cmd.Parameters.AddWithValue("@jumlah", tbJumlahPinjaman.Text);
                cmd.Parameters.AddWithValue("@status", tbStatus.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                loadDataPinjaman();
            }
        }

        private void btnUpdatePinjaman_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_pinjaman SET Id_Buku = @idBuku, NIM = @nim, Jumlah_Pinjaman = @jumlah, Status = @status WHERE Id_Pinjaman = @idPinjaman";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@idPinjaman", tbIdPinjaman.Text);
                cmd.Parameters.AddWithValue("@idBuku", tbIdBuku.Text);
                cmd.Parameters.AddWithValue("@nim", tbNim.Text);
                cmd.Parameters.AddWithValue("@jumlah", tbJumlahPinjaman.Text);
                cmd.Parameters.AddWithValue("@status", tbStatus.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                loadDataPinjaman();
            }
        }

        private void btnHapusPinjaman_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_pinjaman WHERE Id_Pinjaman = @idPinjaman";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@idPinjaman", tbIdPinjaman.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                loadDataPinjaman();
            }
        }

        private void btnRefreshPinjaman_Click(object sender, EventArgs e)
        {
            loadDataPinjaman();
        }

        private void listPinjaman_Click(object sender, EventArgs e)
        {
            tbIdPinjaman.Text = listPinjaman.SelectedItems[0].SubItems[0].Text;
            //tbIdBuku.Text = listPinjaman.SelectedItems[0].SubItems[1].Text;
            //tbNim.Text = listPinjaman.SelectedItems[0].SubItems[2].Text;
            tbJumlahPinjaman.Text = listPinjaman.SelectedItems[0].SubItems[3].Text;
            tbStatus.Text = listPinjaman.SelectedItems[0].SubItems[4].Text;
        }

        private void tbSearchPinjaman_KeyDown(object sender, KeyEventArgs e)
        {
            string itemTerpilih = cbFilterPinjaman.SelectedItem.ToString();
            string query;
            if (e.KeyCode == Keys.Enter)
            {
                if (itemTerpilih.Equals("Id Pinjaman"))
                {
                    query = "SELECT p.Id_Pinjaman, b.Judul, m.Nama, p.Jumlah_Pinjaman, p.Status FROM data_pinjaman as p, data_buku as b, mahasiswa as m WHERE p.Id_Buku = b.Id_buku AND p.NIM = m.NIM AND p.Id_Pinjaman LIKE '%" + tbSearchPinjaman.Text + "%'";
                    searchPinjaman(query);
                }
                else if (itemTerpilih.Equals("Judul Buku"))
                {
                    query = "SELECT p.Id_Pinjaman, b.Judul, m.Nama, p.Jumlah_Pinjaman, p.Status FROM data_pinjaman as p, data_buku as b, mahasiswa as m WHERE p.Id_Buku = b.Id_buku AND p.NIM = m.NIM AND b.Judul LIKE '%" + tbSearchPinjaman.Text + "%'";
                    searchPinjaman(query);
                }
                else if (itemTerpilih.Equals("Nama Mahasiswa"))
                {
                    query = "SELECT p.Id_Pinjaman, b.Judul, m.Nama, p.Jumlah_Pinjaman, p.Status FROM data_pinjaman as p, data_buku as b, mahasiswa as m WHERE p.Id_Buku = b.Id_buku AND p.NIM = m.NIM AND m.Nama LIKE '%" + tbSearchPinjaman.Text + "%'";
                    searchPinjaman(query);
                }
                else if (itemTerpilih.Equals("Jumlah Pinjaman"))
                {
                    query = "SELECT p.Id_Pinjaman, b.Judul, m.Nama, p.Jumlah_Pinjaman, p.Status FROM data_pinjaman as p, data_buku as b, mahasiswa as m WHERE p.Id_Buku = b.Id_buku AND p.NIM = m.NIM AND p.Jumlah_Pinjaman LIKE '%" + tbSearchPinjaman.Text + "%'";
                    searchPinjaman(query);
                }
                else if (itemTerpilih.Equals("Status"))
                {
                    query = "SELECT p.Id_Pinjaman, b.Judul, m.Nama, p.Jumlah_Pinjaman, p.Status FROM data_pinjaman as p, data_buku as b, mahasiswa as m WHERE p.Id_Buku = b.Id_buku AND p.NIM = m.NIM AND p.Status LIKE '%" + tbSearchPinjaman.Text + "%'";
                    searchPinjaman(query);
                }
            }
        }
    }
}
