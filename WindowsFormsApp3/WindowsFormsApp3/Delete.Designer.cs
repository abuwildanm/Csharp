namespace WindowsFormsApp3
{
    partial class HalDelete
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
            this.minimize = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnHapus = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHapus = new System.Windows.Forms.Label();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.SlateGray;
            this.minimize.Location = new System.Drawing.Point(432, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(22, 24);
            this.minimize.TabIndex = 7;
            this.minimize.Text = "-";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.SlateGray;
            this.exit.Location = new System.Drawing.Point(460, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 24);
            this.exit.TabIndex = 6;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.btnHapus,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(494, 243);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.SlateGray;
            this.btnHapus.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.btnHapus.BorderColor = System.Drawing.Color.Transparent;
            this.btnHapus.CornerRadius = 5;
            this.btnHapus.FillColor = System.Drawing.Color.Turquoise;
            this.btnHapus.FillGradientColor = System.Drawing.Color.Turquoise;
            this.btnHapus.Location = new System.Drawing.Point(77, 153);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(338, 51);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.CadetBlue;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.FillColor = System.Drawing.Color.Turquoise;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Turquoise;
            this.rectangleShape1.Location = new System.Drawing.Point(77, 96);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(338, 51);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(188, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Delete";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHapus
            // 
            this.lblHapus.AutoSize = true;
            this.lblHapus.BackColor = System.Drawing.Color.SlateGray;
            this.lblHapus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblHapus.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHapus.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblHapus.Location = new System.Drawing.Point(209, 164);
            this.lblHapus.Name = "lblHapus";
            this.lblHapus.Size = new System.Drawing.Size(70, 24);
            this.lblHapus.TabIndex = 12;
            this.lblHapus.Text = "Hapus";
            this.lblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHapus.Click += new System.EventHandler(this.lblHapus_Click);
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.BackColor = System.Drawing.Color.CadetBlue;
            this.tbKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKodeBarang.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbKodeBarang.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBarang.ForeColor = System.Drawing.Color.AliceBlue;
            this.tbKodeBarang.Location = new System.Drawing.Point(90, 106);
            this.tbKodeBarang.Multiline = true;
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(309, 31);
            this.tbKodeBarang.TabIndex = 36;
            this.tbKodeBarang.Text = "Kode Barang";
            this.tbKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HalDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(494, 243);
            this.Controls.Add(this.tbKodeBarang);
            this.Controls.Add(this.lblHapus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HalDelete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label exit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape btnHapus;
        private System.Windows.Forms.Label lblHapus;
        private System.Windows.Forms.TextBox tbKodeBarang;
    }
}