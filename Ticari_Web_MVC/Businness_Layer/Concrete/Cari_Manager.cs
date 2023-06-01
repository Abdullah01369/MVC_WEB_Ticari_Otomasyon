using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class Cari_Manager
    {
        Cari_Dal cd = new Cari_Dal();

        public void Cari_Ekle(Cari u)
        {
            cd.Cari_Ekle(u);

        }
        public void Cari_Guncelle()
        {
            cd.Cari_Guncelle();
        }

        public List<Cari> Cari_Listele()
        {
            return cd.Cari_Listele();
        }

        public void Cari_Sil(int id)
        {
            cd.Cari_Sil(id);
        }

        public Cari Cari_Getir(int id)
        {
            return cd.Cari_Getir(id);
        }

        public List<Sehir> Sehir_Liste()
        {
            return cd.Sehir_Liste();
        }
        public Cari Cari_Giris(Cari cari)
        {
            return cd.Cari_Giris(cari);
        }
        public Cari Cari_Getir_Mail(string mail)
        {
            return cd.Cari_Getir_Mail(mail);
        }
    }
}
