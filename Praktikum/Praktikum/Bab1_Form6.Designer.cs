namespace Praktikum
{
    partial class Bab1_Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBukaFile = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.tbNamaFile = new System.Windows.Forms.TextBox();
            this.dlgBukaFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "File yang dipilih";
            // 
            // btnBukaFile
            // 
            this.btnBukaFile.Location = new System.Drawing.Point(294, 168);
            this.btnBukaFile.Name = "btnBukaFile";
            this.btnBukaFile.Size = new System.Drawing.Size(75, 23);
            this.btnBukaFile.TabIndex = 1;
            this.btnBukaFile.Text = "Buka File";
            this.btnBukaFile.UseVisualStyleBackColor = true;
            this.btnBukaFile.Click += new System.EventHandler(this.btnBukaFile_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(375, 168);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // tbNamaFile
            // 
            this.tbNamaFile.Location = new System.Drawing.Point(26, 140);
            this.tbNamaFile.Multiline = true;
            this.tbNamaFile.Name = "tbNamaFile";
            this.tbNamaFile.ReadOnly = true;
            this.tbNamaFile.Size = new System.Drawing.Size(424, 22);
            this.tbNamaFile.TabIndex = 3;
            this.tbNamaFile.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 335);
            this.Controls.Add(this.tbNamaFile);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnBukaFile);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBukaFile;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.TextBox tbNamaFile;
        private System.Windows.Forms.OpenFileDialog dlgBukaFile;
    }
}