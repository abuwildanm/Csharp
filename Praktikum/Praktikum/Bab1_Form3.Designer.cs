namespace Praktikum
{
    partial class Bab1_Form3
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
            this.components = new System.ComponentModel.Container();
            this.tbNamaMhs = new System.Windows.Forms.TextBox();
            this.contextMenuNama = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuNama.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNamaMhs
            // 
            this.tbNamaMhs.ContextMenuStrip = this.contextMenuNama;
            this.tbNamaMhs.Location = new System.Drawing.Point(85, 88);
            this.tbNamaMhs.Name = "tbNamaMhs";
            this.tbNamaMhs.Size = new System.Drawing.Size(100, 22);
            this.tbNamaMhs.TabIndex = 0;
            // 
            // contextMenuNama
            // 
            this.contextMenuNama.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuNama.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salinToolStripMenuItem,
            this.tempelToolStripMenuItem,
            this.hapusToolStripMenuItem});
            this.contextMenuNama.Name = "contextMenuStrip1";
            this.contextMenuNama.Size = new System.Drawing.Size(128, 76);
            // 
            // salinToolStripMenuItem
            // 
            this.salinToolStripMenuItem.Name = "salinToolStripMenuItem";
            this.salinToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.salinToolStripMenuItem.Text = "Salin";
            // 
            // tempelToolStripMenuItem
            // 
            this.tempelToolStripMenuItem.Name = "tempelToolStripMenuItem";
            this.tempelToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.tempelToolStripMenuItem.Text = "Tempel";
            // 
            // hapusToolStripMenuItem
            // 
            this.hapusToolStripMenuItem.Name = "hapusToolStripMenuItem";
            this.hapusToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.hapusToolStripMenuItem.Text = "Hapus";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 209);
            this.Controls.Add(this.tbNamaMhs);
            this.Name = "Form3";
            this.Text = "Form3";
            this.contextMenuNama.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNamaMhs;
        private System.Windows.Forms.ContextMenuStrip contextMenuNama;
        private System.Windows.Forms.ToolStripMenuItem salinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusToolStripMenuItem;
    }
}