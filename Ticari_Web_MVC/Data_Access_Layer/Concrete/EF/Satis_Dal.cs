using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Satis_Dal
    {
        Context c = new Context();

        public void Satis_Hareket_Ekle(Satis_Hareket u)
        {
            c.satis_Harekets.Add(u);
            c.SaveChanges();

        }
        public void Satis_Hareket_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Satis_Hareket> Satis_Hareket_Listele()
        {
            return c.satis_Harekets.ToList();
        }

        public void Satis_Hareket_Sil(int id)
        {
            var a = Satis_Hareket_Getir(id);
            c.satis_Harekets.Remove(a);
            c.SaveChanges();

        }

        public Satis_Hareket Satis_Hareket_Getir(int id)
        {
            return c.satis_Harekets.Find(id);
        }
        

    }
}
