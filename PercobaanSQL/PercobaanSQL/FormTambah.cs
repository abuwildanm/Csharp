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
    public partial class FormTambah : Form
    {
        FormUtama fUtama;

        public FormTambah()
        {
            InitializeComponent();
        }

        public FormTambah(FormUtama formUtama)
        {
            InitializeComponent();
            fUtama = formUtama;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(tbNim.Text != "" || tbNama.Text != "" || tbAlamat.Text != "")
            {
                string query = "INSERT INTO mahasiswa VALUES(@nim, @nama, @alamat)";
                try
                {
                    fUtama.myCon.Open();
                    MySqlCommand cmd = new MySqlCommand(query, fUtama.myCon);
                    cmd.Parameters.AddWithValue("@nim", tbNim.Text);
                    cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    fUtama.myCon.Close();
                }
            }
            else
            {
                MessageBox.Show("Semua field harus diisi ya");
            }
        }
    }
}
