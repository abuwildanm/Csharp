using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Si_Indang
{
    public class Controller
    {
        public Barang barang;
        public Kategori kategori;

        public Controller()
        {
            this.barang = new Barang();
            this.kategori = new Kategori();
        }

        public void tampilKategori(DataGridView dgv)
        {
            this.kategori.loadKategori(dgv);
        }

        public void tambahKategori(String id, String nama)
        {
            this.kategori.setIdKategori(id);
            this.kategori.setNamaKategori(nama);

            if (this.kategori.insertKategori())
            {
                MessageBox.Show("Data Berhasil Disimpan!");
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan!");
            }
        }

        public void perbaruiKategori(String id, String nama)
        {
            this.kategori.setIdKategori(id);
            this.kategori.setNamaKategori(nama);

            if (MessageBox.Show("Apakah anda yakin ingin memperbarui data ini?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.kategori.updateKategori())
                {
                    MessageBox.Show("Data Berhasil Diperbarui!");
                }
                else
                {
                    MessageBox.Show("Data Gagal Diperbarui!");
                }
            }
        }

        public void hapusKategori(String id)
        {
            this.kategori.setIdKategori(id);

            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.kategori.deleteKategori())
                {
                    MessageBox.Show("Data Berhasil Dihapus!");
                }
                else
                {
                    MessageBox.Show("Data Gagal Dihapus!");
                }
            }
        }

        public void tampilBarang(DataGridView dgv)
        {
            this.barang.loadBarang(dgv);
        }

        public void tambahBarang(String kode, String nama, int harga, int stok, String idKategori)
        {
            this.barang.setKode(kode);
            this.barang.setNama(nama);
            this.barang.setHarga(harga);
            this.barang.setStok(stok);
            this.barang.setIdKategori(idKategori);

            if (this.barang.insertBarang())
            {
                MessageBox.Show("Data Berhasil Disimpan!");
            }
            else
            {
                MessageBox.Show("Data Gagal Disimpan!");
            }
        }

        public void perbaruiBarang(String kode, String nama, int harga, int stok, String idKategori)
        {
            this.barang.setKode(kode);
            this.barang.setNama(nama);
            this.barang.setHarga(harga);
            this.barang.setStok(stok);
            this.barang.setIdKategori(idKategori);

            if (MessageBox.Show("Apakah anda yakin ingin memperbarui data ini?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.barang.updateBarang())
                {
                    MessageBox.Show("Data Berhasil Diperbarui!");
                }
                else
                {
                    MessageBox.Show("Data Gagal Diperbarui!");
                }
            }
        }

        public void hapusBarang(String kode)
        {
            this.barang.setKode(kode);

            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.barang.deleteBarang())
                {
                    MessageBox.Show("Data Berhasil Dihapus!");
                }
                else
                {
                    MessageBox.Show("Data Gagal Dihapus!");
                }
            }
        }

        public void cariBarang(DataGridView dgv, string kataCari)
        {
            this.barang.searchBarang(dgv, kataCari);
        }

        public void saringBarang(DataGridView dgv, string itemPilihan)
        {
            this.barang.filterBarang(dgv, itemPilihan);
        }
    }
}
