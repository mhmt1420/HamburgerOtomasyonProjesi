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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraEkleme_Click(object sender, EventArgs e)
        {
            Ekstra ekstra = new Ekstra();
            ekstra.ekstraAdi = txtEkstraAd.Text;
            ekstra.ekstraFiyat = Convert.ToDecimal(txtEkstraFiyat.Text);
            Form1.Ekstralar.Add(ekstra);
            this.Close();
        }
    }
}
