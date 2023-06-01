using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Personel_Dal
    {
        Context c = new Context();

        public void Personel_Ekle(Personel u)
        {
            c.personels.Add(u);
            c.SaveChanges();

        }
        public void Personel_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Personel> Personel_Listele()
        {
            return c.personels.ToList(); //DURUM EKLE
        }

        public void Personel_Sil(int id)
        {
            var a = Personel_Getir(id);
            c.personels.Remove(a);
            c.SaveChanges();

        }

        public Personel Personel_Getir(int id)
        {
            return c.personels.Find(id);
        }

        public List<Personel> Personel_Listele_Departman(int id)
        {
            return c.personels.Where(x => x.Departman_Id == id).ToList();

        }
        public List<Satis_Hareket> Personel_Satis_Liste(int id)
        {
            return c.satis_Harekets.Where(x => x.Personel_Id == id).ToList();
        }

        public Personel Personel_Giris(Personel p)
        {
            var user = c.personels.Where(x=>x.Personel_Mail==p.Personel_Mail && x.Personel_Sifre==p.Personel_Sifre).FirstOrDefault();
            return user;
        }
        public Personel Personel_Getir_Mail(string mail) 
        {
            var p = c.personels.FirstOrDefault(x => x.Personel_Mail == mail);
            return p;
        }
    }
}
