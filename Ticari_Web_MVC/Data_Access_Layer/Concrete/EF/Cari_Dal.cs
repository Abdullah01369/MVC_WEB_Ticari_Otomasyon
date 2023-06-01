using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Cari_Dal
    {
        Context c = new Context();


        public void Cari_Ekle(Cari u)
        {
            c.caris.Add(u);
            c.SaveChanges();

        }
        public void Cari_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Cari> Cari_Listele()
        {
            return c.caris.ToList();
        }

        public void Cari_Sil(int id)
        {
            var a = Cari_Getir(id);
            c.caris.Remove(a);
            c.SaveChanges();

        }

        public Cari Cari_Getir(int id)
        {
            return c.caris.Find(id);
        }

        public List<Sehir> Sehir_Liste()
        {
            return c.sehirs.ToList();
        }

        public Cari Cari_Giris(Cari cari)
        {
            var login = c.caris.Where(x => x.Cari_Mail == cari.Cari_Mail && x.Cari_Sifre == cari.Cari_Sifre).FirstOrDefault();
            return login;
        }

        public Cari Cari_Getir_Mail(string mail)
        {
            var p = c.caris.FirstOrDefault(x => x.Cari_Mail == mail);
            return p;
        }
    }
}
