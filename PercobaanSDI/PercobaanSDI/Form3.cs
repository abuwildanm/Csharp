﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercobaanSDI
{
    public partial class Form3 : Form
    {
        private Form form;

        public Form3(Form parentForm)
        {
            InitializeComponent();
            form = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUtama fu = (FormUtama)form;
            fu.Str = textBox1.Text;
        }
    }
}
