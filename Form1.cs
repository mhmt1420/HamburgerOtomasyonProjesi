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


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public List<Siparis> siparisListesi = new List<Siparis>();
        public static List<Menu> menuListesi = new List<Menu>()
        {
            new Menu {MenuAdi="SteakHouse",Fiyat=18.25m },
            new Menu {MenuAdi="McFish",Fiyat=8},
            new Menu {MenuAdi="Whooper",Fiyat=12},
            new Menu {MenuAdi="BigKing",Fiyat=13.75m},
            new Menu {MenuAdi="Chicken Royal",Fiyat=11}
        };
        public static List<Ekstra> Ekstralar = new List<Ekstra>()
        {
            new Ekstra{ekstraAdi="Hardal",ekstraFiyat=0.5m},
            new Ekstra{ekstraAdi="Ketçap",ekstraFiyat=0.5m},
            new Ekstra{ekstraAdi="Ranch",ekstraFiyat=1.5m},
            new Ekstra{ekstraAdi="Mayonez",ekstraFiyat=0.5m},
            new Ekstra{ekstraAdi="Soğan Halkası",ekstraFiyat=5}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //foreach (Menu item in menuListesi)
            //{
            //    cbMenuler.Items.Add(item);
            //} bu yöntemde kullanılabilir.
            cbMenuler.DataSource = menuListesi;
            foreach (Ekstra item in Ekstralar)
            {

                flowLayoutPanel1.Controls.Add(new CheckBox() { Text=item.ekstraAdi,Tag=item});

            }


        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.Adet = (int)nmrAdet.Value;
            if (rbBuyuk.Checked == true)
            {
                siparis.SeciliBoyut = Boyut.Buyuk;
            }
            else if (rbOrta.Checked == true)
            {
                siparis.SeciliBoyut = Boyut.Orta;
            }
            else if(rbKucuk.Checked==true)
            {
                siparis.SeciliBoyut = Boyut.Kucuk;
            }
            siparis.SeciliMenu = (Menu)cbMenuler.SelectedItem;
            siparis.ExtraMalzemesi = new List<Ekstra>();
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked == true)
                {
                    siparis.ExtraMalzemesi.Add((Ekstra)item.Tag);
                }
            }
            siparis.Hesapla();
            siparisListesi.Add(siparis);
            lstSiparisler.Items.Add(siparis.ToString());
            lblTutar.Text = toplamTutarHesapla().ToString("C2");//bilgisayar diline göre para birimi
            
        }
        public decimal toplamTutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < siparisListesi.Count; i++)
            {
                toplamTutar += siparisListesi[i].Tutar;
            }
            return toplamTutar;
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(lblTutar.Text , "Mesaj", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();
                Temizleme.Temizle(this.Controls);
                rbBuyuk.Checked = true;
                MessageBox.Show("Sipariş Tamamlandı");
            }
            else if (dialogResult == DialogResult.No)
            {
                Temizleme.Temizle(this.Controls);
                MessageBox.Show("İptal Edildi");
            }
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.FormClosed += Form_FormClosed;      

        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbMenuler.DataSource = null;
            cbMenuler.DataSource = menuListesi;
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            form.FormClosed += Form_FormClosed1;
            
        }

        private void Form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Ekstra item in Ekstralar)
            {
                
                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = item.ekstraAdi, Tag = item });

            }
        }

        //private void btnYenile_Click(object sender, EventArgs e)
        //{
        //    cbMenuler.DataSource = null;
        //    cbMenuler.DataSource = menuListesi;

        //}
    }
}
