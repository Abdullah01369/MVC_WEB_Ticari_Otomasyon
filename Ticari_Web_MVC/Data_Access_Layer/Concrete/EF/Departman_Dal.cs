using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
   public class Departman_Dal
    {
        Context c = new Context();

        public void Departman_Ekle(Departman k)
        {
            c.departmans.Add(k);
            c.SaveChanges();
        }
        public void Departman_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Departman> Departman_Listele()
        {
            return c.departmans.ToList();
        }

        public void Departman_Sil(int id)
        {
            var a = Departman_Getir(id);
            c.departmans.Remove(a);
            c.SaveChanges();

        }

        public Departman Departman_Getir(int id)
        {
            return c.departmans.Find(id);
        }
    }
}
