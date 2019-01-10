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

namespace PercobaanSQL
{
    public partial class FormUtama : Form
    {
        public MySqlConnection myCon;

        public FormUtama()
        {
            InitializeComponent();
            string conStr = "datasource=localhost; port=3306; username=root; password=root; database=dbcsharp; SslMode=none";
            myCon = new MySqlConnection(conStr);
        }

        private void btnCekKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();
                MessageBox.Show("Koneksi berhasil dibuat");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myCon.Close();
            }
        }

        private void btnAmbil_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM mahasiswa";

            try
            {
                myCon.Open();
                MySqlCommand myCommand = new MySqlCommand(query, myCon);
                MySqlDataReader myReader = myCommand.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while(myReader.Read())
                {
                    sb.Append("NIM: " + myReader[0] + "Nama: " + myReader[1] + "Alamat: " + myReader[2]);
                }
                myReader.Close();
                MessageBox.Show(sb.ToString(), "Data dari database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myCon.Close();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambah fTambah = new FormTambah(this);
            fTambah.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            FormUbah fUbah = new FormUbah(this);
            fUbah.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            FormHapus fHapus = new FormHapus(this);
            fHapus.ShowDialog();
        }
    }
}
