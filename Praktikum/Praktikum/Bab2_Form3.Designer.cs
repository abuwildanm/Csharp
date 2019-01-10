namespace Praktikum
{
    partial class Bab2_Form3
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
            this.labelMouse = new System.Windows.Forms.Label();
            this.labelKeyboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMouse
            // 
            this.labelMouse.AutoSize = true;
            this.labelMouse.Location = new System.Drawing.Point(28, 27);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(98, 17);
            this.labelMouse.TabIndex = 0;
            this.labelMouse.Text = "Mouse Event :";
            // 
            // labelKeyboard
            // 
            this.labelKeyboard.AutoSize = true;
            this.labelKeyboard.Location = new System.Drawing.Point(272, 27);
            this.labelKeyboard.Name = "labelKeyboard";
            this.labelKeyboard.Size = new System.Drawing.Size(117, 17);
            this.labelKeyboard.TabIndex = 1;
            this.labelKeyboard.Text = "Keyboard Event :";
            // 
            // Bab2_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKeyboard);
            this.Controls.Add(this.labelMouse);
            this.Name = "Bab2_Form3";
            this.Text = "165150200111002_Abu Wildan M";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Bab2_Form3_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Bab2_Form3_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.Label labelKeyboard;
    }
}