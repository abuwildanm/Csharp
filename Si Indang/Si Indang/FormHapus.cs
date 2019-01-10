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

namespace Si_Indang
{
    public partial class FormHapus : Form
    {
        public Controller controller;

        public FormHapus()
        {
            InitializeComponent();
            controller = FormUtama.controller;

        }

        public FormHapus(DataGridView dataGridView)
        {
            InitializeComponent();
            tbKode.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString(); // ambil nilai di datagrid
            controller = FormUtama.controller;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            String kode = tbKode.Text;

            controller.hapusBarang(kode);

            //Kosongkan Form
            tbKode.Text = "";

            this.DialogResult = DialogResult.OK;
        }
    }
}

/* Dokumentasi DataGridView
 * SelectedRows[i] = untuk ambil data pada row yang dipilih
 * i = indeks dari row yang dipilih, kalo cuma milih satu row yang indeks-nya cuma 0
 *     kalo milih >1 row, indeksnya bisa 0, 1, 2, dst.
 * Cells[j] = menujukkan kolom dari row yang kita pilih
 * j = indeks dari kolom yang dipilih
 * Value = untuk mengambil nilainya
 */
