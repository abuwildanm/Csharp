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
    public partial class FormUbah : Form
    {
        FormUtama fUtama;

        public FormUbah()
        {
            InitializeComponent();
        }

        public FormUbah(FormUtama formUtama)
        {
            InitializeComponent();
            fUtama = formUtama;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (tbNim.Text != "" || tbNama.Text != "" || tbAlamat.Text != "")
            {
                string query = "UPDATE mahasiswa SET nim=@nim, nama=@nama, alamat=@alamat WHERE nim=@nim";
                try
                {
                    fUtama.myCon.Open();
                    MySqlCommand cmd = new MySqlCommand(query, fUtama.myCon);
                    cmd.Parameters.AddWithValue("@nim", tbNim.Text);
                    cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diubah");
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
