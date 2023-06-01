using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
   public class Kategori_Dal
    {
        Context c = new Context();

        public void Kategori_Ekle(Kategori k) 
        {
            c.kategoris.Add(k);
            c.SaveChanges();
        }
        public void Kategori_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Kategori> Kategori_Listele()
        {
            return c.kategoris.ToList();
        }

        public void Kategori_Sil(int id) 
        {
            var a = Kategori_Getir(id);
            c.kategoris.Remove(a);
            c.SaveChanges();
            
        }

        public Kategori Kategori_Getir(int id)
        {
            return c.kategoris.Find(id);
        }
    }
}
