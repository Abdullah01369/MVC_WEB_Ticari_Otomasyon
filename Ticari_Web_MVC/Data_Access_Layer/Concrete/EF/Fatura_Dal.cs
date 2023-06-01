using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Fatura_Dal
    {

        Context c = new Context();

        public void Fatura_Ekle(Fatura u)
        {
            c.faturas.Add(u);
            c.SaveChanges();

        }
        public void Fatura_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Fatura> Fatura_Listele()
        {
            return c.faturas.ToList();
        }

        public void Fatura_Sil(int id)
        {
            var a = Fatura_Getir(id);
            c.faturas.Remove(a);
            c.SaveChanges();

        }

        public Fatura Fatura_Getir(int id)
        {
            return c.faturas.Find(id);
        }

        public List<Fatura_Kalem> Fatura_Kalem_List(int id)
        {
            return c.fatura_Kalems.Where(x => x.Fatura_Id == id).ToList();
        }


    }
}
