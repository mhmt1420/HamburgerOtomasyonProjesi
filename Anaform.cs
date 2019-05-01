using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamburgerOtomasyon
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        public void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width+22;
            this.Height = _childForm.Height+68;
            bool Durum = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == _childForm.Text)
                {
                    Durum = true;
                    item.Activate();
                }
                else
                {
                    item.Close();
                }
                
            }
            if (Durum == false)
            {
                _childForm.MdiParent = this;//bu sayede mdi'ın içinde gösterdi.
                _childForm.Show();
            }
        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.Show();
            ChildForm(new Form1());
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.Show();
            ChildForm(new Form2());
        }

        private void ekstraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form3 f3 = new Form3();
            //f3.Show();
            ChildForm(new Form3());
        }
    }
}
