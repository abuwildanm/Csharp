namespace Praktikum
{
    partial class Bab2_Form4
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
            this.tbAngka1 = new System.Windows.Forms.TextBox();
            this.tbAngka2 = new System.Windows.Forms.TextBox();
            this.lblHasil = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.kalkulator = new System.Windows.Forms.Panel();
            this.btnKoma = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.kalkulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAngka1
            // 
            this.tbAngka1.Location = new System.Drawing.Point(13, 13);
            this.tbAngka1.Name = "tbAngka1";
            this.tbAngka1.ReadOnly = true;
            this.tbAngka1.Size = new System.Drawing.Size(150, 22);
            this.tbAngka1.TabIndex = 0;
            this.tbAngka1.Enter += new System.EventHandler(this.tbAngka1_Enter);
            // 
            // tbAngka2
            // 
            this.tbAngka2.Location = new System.Drawing.Point(13, 41);
            this.tbAngka2.Name = "tbAngka2";
            this.tbAngka2.ReadOnly = true;
            this.tbAngka2.Size = new System.Drawing.Size(150, 22);
            this.tbAngka2.TabIndex = 1;
            this.tbAngka2.Enter += new System.EventHandler(this.tbAngka2_Enter);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(10, 104);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(37, 17);
            this.lblHasil.TabIndex = 2;
            this.lblHasil.Text = "hasil";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(13, 69);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(33, 23);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnOperasi_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(52, 69);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(33, 23);
            this.btnKurang.TabIndex = 4;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnOperasi_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(91, 69);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(33, 23);
            this.btnKali.TabIndex = 5;
            this.btnKali.Text = "*";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnOperasi_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(130, 69);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(33, 23);
            this.btnBagi.TabIndex = 6;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnOperasi_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 124);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 23);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(62, 124);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 23);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(118, 124);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 23);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 153);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(43, 23);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(62, 153);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 23);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(62, 182);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 23);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(118, 153);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 23);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(118, 182);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 23);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(62, 211);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 23);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 182);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(43, 23);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // kalkulator
            // 
            this.kalkulator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kalkulator.Controls.Add(this.btnKoma);
            this.kalkulator.Controls.Add(this.btnHapus);
            this.kalkulator.Controls.Add(this.tbAngka1);
            this.kalkulator.Controls.Add(this.btn7);
            this.kalkulator.Controls.Add(this.tbAngka2);
            this.kalkulator.Controls.Add(this.btn0);
            this.kalkulator.Controls.Add(this.lblHasil);
            this.kalkulator.Controls.Add(this.btn9);
            this.kalkulator.Controls.Add(this.btnTambah);
            this.kalkulator.Controls.Add(this.btn6);
            this.kalkulator.Controls.Add(this.btnKurang);
            this.kalkulator.Controls.Add(this.btn8);
            this.kalkulator.Controls.Add(this.btnKali);
            this.kalkulator.Controls.Add(this.btn5);
            this.kalkulator.Controls.Add(this.btnBagi);
            this.kalkulator.Controls.Add(this.btn4);
            this.kalkulator.Controls.Add(this.btn1);
            this.kalkulator.Controls.Add(this.btn3);
            this.kalkulator.Controls.Add(this.btn2);
            this.kalkulator.Location = new System.Drawing.Point(141, 21);
            this.kalkulator.Name = "kalkulator";
            this.kalkulator.Size = new System.Drawing.Size(175, 242);
            this.kalkulator.TabIndex = 17;
            // 
            // btnKoma
            // 
            this.btnKoma.Location = new System.Drawing.Point(118, 211);
            this.btnKoma.Name = "btnKoma";
            this.btnKoma.Size = new System.Drawing.Size(45, 23);
            this.btnKoma.TabIndex = 18;
            this.btnKoma.Text = ",";
            this.btnKoma.UseVisualStyleBackColor = true;
            this.btnKoma.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(13, 211);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(43, 23);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "C";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Bab2_Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 284);
            this.Controls.Add(this.kalkulator);
            this.Name = "Bab2_Form4";
            this.Text = "165150200111002_Abu Wildan M";
            this.kalkulator.ResumeLayout(false);
            this.kalkulator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbAngka1;
        private System.Windows.Forms.TextBox tbAngka2;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Panel kalkulator;
        private System.Windows.Forms.Button btnKoma;
        private System.Windows.Forms.Button btnHapus;
    }
}