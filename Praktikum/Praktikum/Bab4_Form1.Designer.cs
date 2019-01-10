namespace Praktikum
{
    partial class Bab4_Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_judul = new System.Windows.Forms.Label();
            this.label_pengarang = new System.Windows.Forms.Label();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_judul = new System.Windows.Forms.TextBox();
            this.text_pengarang = new System.Windows.Forms.TextBox();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.listBuku = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Tambah = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.tbSearchBuku = new System.Windows.Forms.TextBox();
            this.label_searchBuku = new System.Windows.Forms.Label();
            this.cbFilterBuku = new System.Windows.Forms.ComboBox();
            this.label_filterBuku = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterPinjaman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchPinjaman = new System.Windows.Forms.TextBox();
            this.btnRefreshPinjaman = new System.Windows.Forms.Button();
            this.btnHapusPinjaman = new System.Windows.Forms.Button();
            this.btnUpdatePinjaman = new System.Windows.Forms.Button();
            this.btnTambahPinjaman = new System.Windows.Forms.Button();
            this.listPinjaman = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbJumlahPinjaman = new System.Windows.Forms.TextBox();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.tbIdBuku = new System.Windows.Forms.TextBox();
            this.tbIdPinjaman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(27, 52);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(55, 17);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id Buku";
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(27, 90);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(78, 17);
            this.label_judul.TabIndex = 1;
            this.label_judul.Text = "Judul Buku";
            // 
            // label_pengarang
            // 
            this.label_pengarang.AutoSize = true;
            this.label_pengarang.Location = new System.Drawing.Point(27, 127);
            this.label_pengarang.Name = "label_pengarang";
            this.label_pengarang.Size = new System.Drawing.Size(78, 17);
            this.label_pengarang.TabIndex = 2;
            this.label_pengarang.Text = "Pengarang";
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(27, 167);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(53, 17);
            this.label_jumlah.TabIndex = 3;
            this.label_jumlah.Text = "Jumlah";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(154, 52);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(230, 22);
            this.text_id.TabIndex = 4;
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(154, 90);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(230, 22);
            this.text_judul.TabIndex = 5;
            // 
            // text_pengarang
            // 
            this.text_pengarang.Location = new System.Drawing.Point(154, 127);
            this.text_pengarang.Name = "text_pengarang";
            this.text_pengarang.Size = new System.Drawing.Size(230, 22);
            this.text_pengarang.TabIndex = 6;
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(154, 164);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(230, 22);
            this.text_jumlah.TabIndex = 7;
            // 
            // listBuku
            // 
            this.listBuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBuku.FullRowSelect = true;
            this.listBuku.Location = new System.Drawing.Point(410, 52);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(691, 198);
            this.listBuku.TabIndex = 8;
            this.listBuku.UseCompatibleStateImageBehavior = false;
            this.listBuku.View = System.Windows.Forms.View.Details;
            this.listBuku.Click += new System.EventHandler(this.listBuku_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Buku";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judul Buku";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pengarang";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jumlah";
            // 
            // button_Tambah
            // 
            this.button_Tambah.Location = new System.Drawing.Point(30, 307);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(75, 33);
            this.button_Tambah.TabIndex = 9;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = true;
            this.button_Tambah.Click += new System.EventHandler(this.button_Tambah_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(111, 307);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 33);
            this.button_Update.TabIndex = 10;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Location = new System.Drawing.Point(192, 307);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(75, 33);
            this.button_Hapus.TabIndex = 11;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(995, 256);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(106, 28);
            this.button_refresh.TabIndex = 12;
            this.button_refresh.Text = "Refresh Data";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // tbSearchBuku
            // 
            this.tbSearchBuku.Location = new System.Drawing.Point(1001, 18);
            this.tbSearchBuku.Name = "tbSearchBuku";
            this.tbSearchBuku.Size = new System.Drawing.Size(100, 22);
            this.tbSearchBuku.TabIndex = 13;
            this.tbSearchBuku.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchBuku_KeyDown);
            // 
            // label_searchBuku
            // 
            this.label_searchBuku.AutoSize = true;
            this.label_searchBuku.Location = new System.Drawing.Point(934, 18);
            this.label_searchBuku.Name = "label_searchBuku";
            this.label_searchBuku.Size = new System.Drawing.Size(61, 17);
            this.label_searchBuku.TabIndex = 14;
            this.label_searchBuku.Text = "Search :";
            // 
            // cbFilterBuku
            // 
            this.cbFilterBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBuku.FormattingEnabled = true;
            this.cbFilterBuku.Items.AddRange(new object[] {
            "Judul",
            "Pengarang"});
            this.cbFilterBuku.Location = new System.Drawing.Point(798, 16);
            this.cbFilterBuku.Name = "cbFilterBuku";
            this.cbFilterBuku.Size = new System.Drawing.Size(121, 24);
            this.cbFilterBuku.TabIndex = 15;
            // 
            // label_filterBuku
            // 
            this.label_filterBuku.AutoSize = true;
            this.label_filterBuku.Location = new System.Drawing.Point(696, 19);
            this.label_filterBuku.Name = "label_filterBuku";
            this.label_filterBuku.Size = new System.Drawing.Size(96, 17);
            this.label_filterBuku.TabIndex = 16;
            this.label_filterBuku.Text = "Search Filter :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_refresh);
            this.groupBox1.Controls.Add(this.label_filterBuku);
            this.groupBox1.Controls.Add(this.label_searchBuku);
            this.groupBox1.Controls.Add(this.cbFilterBuku);
            this.groupBox1.Controls.Add(this.tbSearchBuku);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 364);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Buku";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbStatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbFilterPinjaman);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSearchPinjaman);
            this.groupBox2.Controls.Add(this.btnRefreshPinjaman);
            this.groupBox2.Controls.Add(this.btnHapusPinjaman);
            this.groupBox2.Controls.Add(this.btnUpdatePinjaman);
            this.groupBox2.Controls.Add(this.btnTambahPinjaman);
            this.groupBox2.Controls.Add(this.listPinjaman);
            this.groupBox2.Controls.Add(this.tbJumlahPinjaman);
            this.groupBox2.Controls.Add(this.tbNim);
            this.groupBox2.Controls.Add(this.tbIdBuku);
            this.groupBox2.Controls.Add(this.tbIdPinjaman);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1113, 373);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Peminjaman";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(147, 206);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(237, 22);
            this.tbStatus.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search Filter :";
            // 
            // cbFilterPinjaman
            // 
            this.cbFilterPinjaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterPinjaman.FormattingEnabled = true;
            this.cbFilterPinjaman.Items.AddRange(new object[] {
            "Id Pinjaman",
            "Judul Buku",
            "Nama Mahasiswa",
            "Jumlah Pinjaman",
            "Status"});
            this.cbFilterPinjaman.Location = new System.Drawing.Point(798, 21);
            this.cbFilterPinjaman.Name = "cbFilterPinjaman";
            this.cbFilterPinjaman.Size = new System.Drawing.Size(121, 24);
            this.cbFilterPinjaman.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(934, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search :";
            // 
            // tbSearchPinjaman
            // 
            this.tbSearchPinjaman.Location = new System.Drawing.Point(1001, 23);
            this.tbSearchPinjaman.Name = "tbSearchPinjaman";
            this.tbSearchPinjaman.Size = new System.Drawing.Size(100, 22);
            this.tbSearchPinjaman.TabIndex = 30;
            this.tbSearchPinjaman.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchPinjaman_KeyDown);
            // 
            // btnRefreshPinjaman
            // 
            this.btnRefreshPinjaman.Location = new System.Drawing.Point(995, 260);
            this.btnRefreshPinjaman.Name = "btnRefreshPinjaman";
            this.btnRefreshPinjaman.Size = new System.Drawing.Size(106, 28);
            this.btnRefreshPinjaman.TabIndex = 29;
            this.btnRefreshPinjaman.Text = "Refresh Data";
            this.btnRefreshPinjaman.UseVisualStyleBackColor = true;
            this.btnRefreshPinjaman.Click += new System.EventHandler(this.btnRefreshPinjaman_Click);
            // 
            // btnHapusPinjaman
            // 
            this.btnHapusPinjaman.Location = new System.Drawing.Point(185, 311);
            this.btnHapusPinjaman.Name = "btnHapusPinjaman";
            this.btnHapusPinjaman.Size = new System.Drawing.Size(75, 33);
            this.btnHapusPinjaman.TabIndex = 28;
            this.btnHapusPinjaman.Text = "Hapus";
            this.btnHapusPinjaman.UseVisualStyleBackColor = true;
            this.btnHapusPinjaman.Click += new System.EventHandler(this.btnHapusPinjaman_Click);
            // 
            // btnUpdatePinjaman
            // 
            this.btnUpdatePinjaman.Location = new System.Drawing.Point(104, 311);
            this.btnUpdatePinjaman.Name = "btnUpdatePinjaman";
            this.btnUpdatePinjaman.Size = new System.Drawing.Size(75, 33);
            this.btnUpdatePinjaman.TabIndex = 27;
            this.btnUpdatePinjaman.Text = "Update";
            this.btnUpdatePinjaman.UseVisualStyleBackColor = true;
            this.btnUpdatePinjaman.Click += new System.EventHandler(this.btnUpdatePinjaman_Click);
            // 
            // btnTambahPinjaman
            // 
            this.btnTambahPinjaman.Location = new System.Drawing.Point(23, 311);
            this.btnTambahPinjaman.Name = "btnTambahPinjaman";
            this.btnTambahPinjaman.Size = new System.Drawing.Size(75, 33);
            this.btnTambahPinjaman.TabIndex = 26;
            this.btnTambahPinjaman.Text = "Tambah";
            this.btnTambahPinjaman.UseVisualStyleBackColor = true;
            this.btnTambahPinjaman.Click += new System.EventHandler(this.btnTambahPinjaman_Click);
            // 
            // listPinjaman
            // 
            this.listPinjaman.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listPinjaman.FullRowSelect = true;
            this.listPinjaman.Location = new System.Drawing.Point(410, 56);
            this.listPinjaman.Name = "listPinjaman";
            this.listPinjaman.Size = new System.Drawing.Size(691, 198);
            this.listPinjaman.TabIndex = 25;
            this.listPinjaman.UseCompatibleStateImageBehavior = false;
            this.listPinjaman.View = System.Windows.Forms.View.Details;
            this.listPinjaman.Click += new System.EventHandler(this.listPinjaman_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id Pinjaman";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Judul Buku";
            this.columnHeader6.Width = 127;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nama Mahasiswa";
            this.columnHeader7.Width = 148;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Jumlah Pinjaman";
            this.columnHeader8.Width = 86;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            // 
            // tbJumlahPinjaman
            // 
            this.tbJumlahPinjaman.Location = new System.Drawing.Point(147, 168);
            this.tbJumlahPinjaman.Name = "tbJumlahPinjaman";
            this.tbJumlahPinjaman.Size = new System.Drawing.Size(237, 22);
            this.tbJumlahPinjaman.TabIndex = 24;
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(147, 131);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(237, 22);
            this.tbNim.TabIndex = 23;
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Location = new System.Drawing.Point(147, 94);
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(237, 22);
            this.tbIdBuku.TabIndex = 22;
            // 
            // tbIdPinjaman
            // 
            this.tbIdPinjaman.Location = new System.Drawing.Point(147, 56);
            this.tbIdPinjaman.Name = "tbIdPinjaman";
            this.tbIdPinjaman.Size = new System.Drawing.Size(237, 22);
            this.tbIdPinjaman.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Jumlah Pinjaman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "NIM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Id Buku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Id Pinjaman";
            // 
            // Bab4_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Tambah);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.text_pengarang);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.label_pengarang);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bab4_Form1";
            this.Text = "165150200111002_Abu Wildan M";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.Label label_pengarang;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.TextBox text_pengarang;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.ListView listBuku;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbSearchBuku;
        private System.Windows.Forms.Label label_searchBuku;
        private System.Windows.Forms.ComboBox cbFilterBuku;
        private System.Windows.Forms.Label label_filterBuku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterPinjaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchPinjaman;
        private System.Windows.Forms.Button btnRefreshPinjaman;
        private System.Windows.Forms.Button btnHapusPinjaman;
        private System.Windows.Forms.Button btnUpdatePinjaman;
        private System.Windows.Forms.Button btnTambahPinjaman;
        private System.Windows.Forms.ListView listPinjaman;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox tbJumlahPinjaman;
        private System.Windows.Forms.TextBox tbNim;
        private System.Windows.Forms.TextBox tbIdBuku;
        private System.Windows.Forms.TextBox tbIdPinjaman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}