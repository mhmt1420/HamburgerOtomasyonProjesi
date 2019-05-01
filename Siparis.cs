using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgerOtomasyon
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut SeciliBoyut { get; set; }
        public List<Ekstra> ExtraMalzemesi { get; set; }
        public int Adet { get; set; }
        public decimal Tutar { get; set; }
        public string concatenatedTwo { get; set; }
        public void Hesapla()
        {
            Tutar = 0;
            Tutar += SeciliMenu.Fiyat;
            switch (SeciliBoyut)
            {
                
                case Boyut.Orta: Tutar += (SeciliMenu.Fiyat * (0.1m));
                    break;
                case Boyut.Buyuk: Tutar += (SeciliMenu.Fiyat * (0.2m));
                    break;
             
            }
            foreach (Ekstra item in ExtraMalzemesi)
            {
                Tutar += item.ekstraFiyat;
            }
            Tutar = Tutar * this.Adet;

        }
        public override string ToString() //listbox'a eklerken ToString() metodunu kullanıyor.
        {
            
            for (int i = 0; i < ExtraMalzemesi.Count; i++)
            {
                concatenatedTwo += string.Concat(" "+ExtraMalzemesi[i].ekstraAdi);
                
            }
            
            return string.Format("{0} Menü, {1} Adeti, {2} Boy, Toplam: {3}, Malzemeler: {4}", this.SeciliMenu.MenuAdi, this.Adet.ToString(), this.SeciliBoyut.ToString(), this.Tutar.ToString(), concatenatedTwo);
        }

    }
}
