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
    public partial class HalDelete : Form
    {
        MySqlConnection connection = HalKasir.connection;

        public HalDelete()
        {
            InitializeComponent();
        }

        public HalDelete(DataGridView dgv)
        {
            InitializeComponent();
            tbKodeBarang.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
        }

        public void delete()
        {
            string query = "DELETE FROM barang WHERE Kode_Barang = @kode";

            try
            {
                //Inisialisasi Command
                MySqlCommand command = connection.CreateCommand();

                //Input Data Query
                command.CommandText = query;

                //Tambahkan Parameter
                command.Parameters.AddWithValue("@kode", tbKodeBarang.Text);

                //Eksekusi Query
                command.ExecuteNonQuery();

                //Pesan Berhasil
                MessageBox.Show("Data Berhasil Dihapus!");

                //Kosongkan Form
                tbKodeBarang.Text = "Kode Barang";
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

        private void lblHapus_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                delete();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
