namespace Praktikum
{
    partial class Bab2_Form2
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
            this.btnEnable = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnVisible = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(37, 79);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(75, 23);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "Disable";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(37, 39);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(156, 22);
            this.textBox.TabIndex = 1;
            this.textBox.EnabledChanged += new System.EventHandler(this.textBox_EnabledChanged);
            this.textBox.VisibleChanged += new System.EventHandler(this.textBox_VisibleChanged);
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // btnVisible
            // 
            this.btnVisible.Location = new System.Drawing.Point(118, 79);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(75, 23);
            this.btnVisible.TabIndex = 2;
            this.btnVisible.Text = "Unvisible";
            this.btnVisible.UseVisualStyleBackColor = true;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(298, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 17);
            this.label.TabIndex = 3;
            this.label.Text = "label";
            // 
            // Bab2_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 135);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnEnable);
            this.Name = "Bab2_Form2";
            this.Text = "165150200111002_Abu Wildan M";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnVisible;
        private System.Windows.Forms.Label label;
    }
}