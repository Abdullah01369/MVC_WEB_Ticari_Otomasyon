using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Kargo_Dal
    {
        Context c = new Context();

        public void Kargo_Ekle(Kargo k)
        {
            c.Kargos.Add(k);
            c.SaveChanges();
        }
        public void Kargo_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Kargo> Kargo_Listele()
        {
            return c.Kargos.ToList();
        }

        public void Kargo_Iptal(int id)
        {
            var a = Kargo_Getir(id);
            a.Aktiflik = false;
            c.SaveChanges();

        }

        public Kargo Kargo_Getir(int id)
        {
            return c.Kargos.Find(id);
        }
    }

}
