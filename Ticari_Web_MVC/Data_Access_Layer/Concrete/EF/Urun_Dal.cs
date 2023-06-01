using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
   public class Urun_Dal
    {
        Context c = new Context();

        public void Urun_Ekle(Urun u) 
        {
            c.uruns.Add(u);
            c.SaveChanges();

        }
        public void Urun_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Urun> Urun_Listele()
        {
            return c.uruns.Where(x=>x.Durum==true).ToList();
        }

        public void Urun_Sil(int id)
        {
            var a = Urun_Getir(id);
            c.uruns.Remove(a);
            c.SaveChanges();

        }

        public Urun Urun_Getir(int id)
        {
            return c.uruns.Find(id);
        }

       
    }
}
