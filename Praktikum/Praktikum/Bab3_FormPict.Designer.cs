namespace Praktikum
{
    partial class Bab3_FormPict
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSetDegreeAll = new System.Windows.Forms.Button();
            this.btnApplyDegree = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAturZoom = new System.Windows.Forms.Button();
            this.btnApplyZoom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApplyZoom);
            this.panel1.Controls.Add(this.btnAturZoom);
            this.panel1.Controls.Add(this.btnApplyDegree);
            this.panel1.Controls.Add(this.btnSetDegreeAll);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 70);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnSetDegreeAll
            // 
            this.btnSetDegreeAll.Location = new System.Drawing.Point(129, 13);
            this.btnSetDegreeAll.Name = "btnSetDegreeAll";
            this.btnSetDegreeAll.Size = new System.Drawing.Size(130, 45);
            this.btnSetDegreeAll.TabIndex = 2;
            this.btnSetDegreeAll.Text = "Set Degree All";
            this.btnSetDegreeAll.UseVisualStyleBackColor = true;
            this.btnSetDegreeAll.Click += new System.EventHandler(this.btnSetDegreeAll_Click);
            // 
            // btnApplyDegree
            // 
            this.btnApplyDegree.Location = new System.Drawing.Point(265, 13);
            this.btnApplyDegree.Name = "btnApplyDegree";
            this.btnApplyDegree.Size = new System.Drawing.Size(130, 45);
            this.btnApplyDegree.TabIndex = 3;
            this.btnApplyDegree.Text = "Apply Degree";
            this.btnApplyDegree.UseVisualStyleBackColor = true;
            this.btnApplyDegree.Click += new System.EventHandler(this.btnApplyDegree_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAturZoom
            // 
            this.btnAturZoom.Location = new System.Drawing.Point(401, 13);
            this.btnAturZoom.Name = "btnAturZoom";
            this.btnAturZoom.Size = new System.Drawing.Size(130, 45);
            this.btnAturZoom.TabIndex = 4;
            this.btnAturZoom.Text = "Atur Zoom Level";
            this.btnAturZoom.UseVisualStyleBackColor = true;
            this.btnAturZoom.Click += new System.EventHandler(this.btnAturZoom_Click);
            // 
            // btnApplyZoom
            // 
            this.btnApplyZoom.Location = new System.Drawing.Point(537, 13);
            this.btnApplyZoom.Name = "btnApplyZoom";
            this.btnApplyZoom.Size = new System.Drawing.Size(130, 45);
            this.btnApplyZoom.TabIndex = 5;
            this.btnApplyZoom.Text = "Apply Zoom Level";
            this.btnApplyZoom.UseVisualStyleBackColor = true;
            this.btnApplyZoom.Click += new System.EventHandler(this.btnApplyZoom_Click);
            // 
            // Bab3_FormPict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Bab3_FormPict";
            this.Text = "Bab3_FormPict";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApplyDegree;
        private System.Windows.Forms.Button btnSetDegreeAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnApplyZoom;
        private System.Windows.Forms.Button btnAturZoom;
    }
}