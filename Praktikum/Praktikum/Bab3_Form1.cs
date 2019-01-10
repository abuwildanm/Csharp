using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum
{
    public partial class Bab3_Form1 : Form, INotifyPropertyChanged
    {
        string ActiveForm, size;
        List<Bab3_FormPict> frmPict = new List<Bab3_FormPict>();
        List<ToolStripMenuItem> TsItem = new List<ToolStripMenuItem>();
        ToolStripMenuItem Ts;
        public event PropertyChangedEventHandler PropertyChanged;
        private int AllDegree;

        public Bab3_Form1()
        {
            InitializeComponent();
            Bab3_FormPict FP;
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
            ToolStripMenuItem item = (ToolStripMenuItem)menuStrip1.Items["windowToolStripMenuItem"];
            foreach (ToolStripMenuItem itemChecked in item.DropDownItems)
            {
                if (!itemChecked.Text.Equals(v)) itemChecked.Checked = false;
                else itemChecked.Checked = true;
            }
        }

        public string ActiveForm1
        {
            get { return ActiveForm; }
            set { ActiveForm = value; OnPropertyChanged(ActiveForm1); }
        }

        public int AllDegree1
        {
            get { return AllDegree; }
            set { AllDegree = value; }
        }

        public string size1
        {
            get { return size; }
            set { size = value; }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frmPict.Add(new Bab3_FormPict(this) {
                    Text = System.IO.Path.GetFileName(openFileDialog1.FileName),
                    MdiParent = this
                });
                frmPict[frmPict.Count - 1].setPic(Image.FromFile(openFileDialog1.FileName));
                frmPict[frmPict.Count - 1].Show();
                ToolStripMenuItem item = (ToolStripMenuItem)menuStrip1.Items["windowToolStripMenuItem"];
                foreach (ToolStripMenuItem itemChecked in item.DropDownItems)
                {
                    itemChecked.Checked = false;
                }
                TsItem.Add(new ToolStripMenuItem(null, null, ItemClick)
                {
                    Text = System.IO.Path.GetFileName(openFileDialog1.FileName),
                    Checked = true
                });
                item.DropDownItems.Add(TsItem[TsItem.Count - 1]);
            }
        }

        private void ItemClick(object sender, EventArgs e)
        {
            var tms = (ToolStripMenuItem)sender;
            for (int i = 0; i < frmPict.Count; i++)
            {
                if (String.Equals(frmPict[i].Text, tms.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    frmPict[i].Activate();
                }
            }
        }

        private void rotateRightToolStripButton_Click(object sender, EventArgs e)
        {
            Bab3_FormPict tempChild = (Bab3_FormPict)this.ActiveMdiChild;
            tempChild.PutarKanan();
        }

        private void rotateLeftToolStripButton_Click(object sender, EventArgs e)
        {
            Bab3_FormPict tempChild = (Bab3_FormPict)this.ActiveMdiChild;
            tempChild.PutarKiri();
        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            Bab3_FormPict tempChild = (Bab3_FormPict)this.ActiveMdiChild;
            tempChild.Perbesar();
        }

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {
            Bab3_FormPict tempChild = (Bab3_FormPict)this.ActiveMdiChild;
            tempChild.Perkecil();
        }
    }
}