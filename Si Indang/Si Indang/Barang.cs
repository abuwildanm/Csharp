using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Si_Indang
{
    public class Barang
    {
        private Koneksi koneksi;
        private String kode;
        private String nama;
        private int harga;
        private int stok;
        private Kategori kategori;

        public Barang()
        {
            koneksi = new Koneksi();
            kategori = new Kategori();
        }

        public void setKode(String kode)
        {
            this.kode = kode;
        }

        public void setNama(String nama)
        {
            this.nama = nama;
        }

        public void setHarga(int harga)
        {
            this.harga = harga;
        }

        public void setStok(int stok)
        {
            this.stok = stok;
        }

        public void setIdKategori(String id)
        {
            kategori.setIdKategori(id);
        }

        public String getKode()
        {
            return this.kode;
        }

        public String getNama()
        {
            return this.nama;
        }

        public int getHarga()
        {
            return this.harga;
        }

        public int getStok()
        {
            return this.stok;
        }

        public String getIdKategori()
        {
            return kategori.getIdKategori();
        }

        public void loadBarang(DataGridView dataGrid)
        {
            string query = "SELECT Kode, Nama, Harga, Stok, Kategori FROM barang as b JOIN kategori as k ON b.ID_Kategori = k.ID_Kategori";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Masukkan data ke datagrid
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGrid.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.connection.Close();
            }
        }

        public bool insertBarang()
        {
            string query = "INSERT INTO barang(Kode, Nama, Harga, Stok, ID_Kategori) VALUES (@kode, @nama, @harga, @stok, @kategori)";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@kode", this.kode);
                command.Parameters.AddWithValue("@nama", this.nama);
                command.Parameters.AddWithValue("@harga", this.harga);
                command.Parameters.AddWithValue("@stok", this.stok);
                command.Parameters.AddWithValue("@kategori", this.getIdKategori());

                //Eksekusi Query
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                koneksi.connection.Close();
            }
        }

        public bool updateBarang()
        {
            string query = "UPDATE barang SET Kode = @kode, Nama = @nama, Harga = @harga, Stok = @stok, ID_Kategori = @kategori WHERE Kode = @kode";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@kode", this.kode);
                command.Parameters.AddWithValue("@nama", this.nama);
                command.Parameters.AddWithValue("@harga", this.harga);
                command.Parameters.AddWithValue("@stok", this.stok);
                command.Parameters.AddWithValue("@kategori", this.getIdKategori());

                //Eksekusi Query
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                koneksi.connection.Close();
            }
        }

        public bool deleteBarang()
        {
            string query = "DELETE FROM barang WHERE Kode = @kode";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@kode", this.kode);

                //Eksekusi Query
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                koneksi.connection.Close();
            }
        }

        public void searchBarang(DataGridView dataGrid, string kataCari)
        {
            string query = "SELECT Kode, Nama, Harga, Stok, Kategori FROM barang as b JOIN kategori as k ON b.ID_Kategori = k.ID_Kategori WHERE Nama LIKE '%" + kataCari + "%'";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Masukkan data ke datagrid
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGrid.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.connection.Close();
            }
        }

        public void filterBarang(DataGridView dataGrid, string itemPilihan)
        {
            string query = "SELECT Kode, Nama, Harga, Stok, Kategori FROM barang as b JOIN kategori as k ON b.ID_Kategori = k.ID_Kategori WHERE Kategori LIKE '%" + itemPilihan + "%'";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Masukkan data ke datagrid
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGrid.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.connection.Close();
            }
        }
    }
}
