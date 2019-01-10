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
    public partial class FormHapus : Form
    {
        FormUtama fUtama;

        public FormHapus()
        {
            InitializeComponent();
        }

        public FormHapus(FormUtama formUtama)
        {
            InitializeComponent();
            fUtama = formUtama;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (tbNim.Text != "")
            {
                string query = "DELETE FROM mahasiswa WHERE nim = @nim";
                try
                {
                    fUtama.myCon.Open();
                    MySqlCommand cmd = new MySqlCommand(query, fUtama.myCon);
                    cmd.Parameters.AddWithValue("@nim", tbNim.Text);
                    int abc = cmd.ExecuteNonQuery(); //mengembalikan nilai row yang terpengaruh akibat ekseskusi query

                    if(abc > 0) //jika abc > 0, berarti ada row yang terpengaruh
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Apaan, data gak ketemu! jangan ngaco");
                    }
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
                MessageBox.Show("Isi NIM terlebih dahulu");
            }
        }
    }
}
