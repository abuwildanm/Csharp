using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Si_Indang
{
    public class Kategori
    {
        private Koneksi koneksi;
        private String idKategori;
        private String namaKategori;

        public Kategori()
        {
            koneksi = new Koneksi();
        }
        
        public void setIdKategori(String id)
        {
            this.idKategori = id;
        }

        public void setNamaKategori(String nama)
        {
            this.namaKategori = nama;
        }

        public String getIdKategori()
        {
            return this.idKategori;
        }

        public String getNamaKategori()
        {
            return this.namaKategori;
        }

        public void loadKategori(DataGridView dataGrid)
        {
            string query = "SELECT * FROM kategori";

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

        public bool insertKategori()
        {
            string query = "INSERT INTO kategori(ID_Kategori, Kategori) VALUES (@idKategori, @namaKategori)";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@idKategori", this.idKategori);
                command.Parameters.AddWithValue("@namaKategori", this.namaKategori);

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

        public bool updateKategori()
        {
            string query = "UPDATE kategori SET ID_Kategori = @idKategori, Kategori = @namaKategori WHERE ID_Kategori = @idKategori";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@idKategori", this.idKategori);
                command.Parameters.AddWithValue("@namaKategori", this.namaKategori);

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

        public bool deleteKategori()
        {
            string query = "DELETE FROM kategori WHERE ID_Kategori = @idKategori";

            try
            {
                koneksi.connection.Open();

                //Inisialisasi Command
                MySqlCommand command = koneksi.connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@idKategori", this.idKategori);

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
    }
}
