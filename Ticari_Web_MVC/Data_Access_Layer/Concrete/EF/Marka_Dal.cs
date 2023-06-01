using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Marka_Dal
    {
        Context c = new Context();

        public void Marka_Ekle(Marka k)
        {
            c.markas.Add(k);
            c.SaveChanges();
        }
        public void Marka_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Marka> Marka_Listele()
        {
            return c.markas.ToList();
        }

        public void Marka_Sil(int id)
        {
            var a = Marka_Getir(id);
            c.markas.Remove(a);
            c.SaveChanges();

        }

        public Marka Marka_Getir(int id)
        {
            return c.markas.Find(id);
        }
    }
}
