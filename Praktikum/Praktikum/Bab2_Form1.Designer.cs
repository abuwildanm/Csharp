namespace Praktikum
{
    partial class Bab2_Form1
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
            this.btUbah = new System.Windows.Forms.Button();
            this.lbHalo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btUbah
            // 
            this.btUbah.Location = new System.Drawing.Point(347, 38);
            this.btUbah.Name = "btUbah";
            this.btUbah.Size = new System.Drawing.Size(90, 23);
            this.btUbah.TabIndex = 0;
            this.btUbah.Text = "Ubah Label";
            this.btUbah.UseVisualStyleBackColor = true;
            this.btUbah.Click += new System.EventHandler(this.tutupAplikasi);
            // 
            // lbHalo
            // 
            this.lbHalo.AutoSize = true;
            this.lbHalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHalo.Location = new System.Drawing.Point(40, 43);
            this.lbHalo.Name = "lbHalo";
            this.lbHalo.Size = new System.Drawing.Size(39, 18);
            this.lbHalo.TabIndex = 1;
            this.lbHalo.Text = "Halo";
            // 
            // Bab2_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 103);
            this.Controls.Add(this.lbHalo);
            this.Controls.Add(this.btUbah);
            this.Name = "Bab2_Form1";
            this.Text = "165150200111002_Abu Wildan M";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUbah;
        private System.Windows.Forms.Label lbHalo;
    }
}