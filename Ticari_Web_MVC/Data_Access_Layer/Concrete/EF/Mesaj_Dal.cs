using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Mesaj_Dal
    {
        Context c = new Context();

        public void Mesaj_Ekle(Mesaj u)
        {
            c.Mesajs.Add(u);
            c.SaveChanges();

        }
        public void Mesaj_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Mesaj> Mesaj_Listele_Mail_Gelen(string mail)
        {
            return c.Mesajs.Where(x => x.Alici == mail).OrderByDescending(x=>x.Mesaj_Id).ToList();
        }

        public List<Mesaj> Mesaj_Listele_Mail_Giden(string mail)
        {
            return c.Mesajs.Where(x => x.Gonderici == mail).OrderByDescending(x => x.Mesaj_Id).ToList();
        }

        public void Mesaj_Sil(int id)
        {
            var a = Mesaj_Getir(id);
            c.Mesajs.Remove(a);
            c.SaveChanges();

        }

        public Mesaj Mesaj_Getir(int id)
        {
            return c.Mesajs.Find(id);
        }

        public Mesaj Mesaj_Detay_Getir(int id)
        {
          return  c.Mesajs.FirstOrDefault(x => x.Mesaj_Id == id);
        }
      
        public void Mesaj_Gonder(Mesaj m)
        {
            c.Mesajs.Add(m);
            c.SaveChanges();
        }

    }
}
