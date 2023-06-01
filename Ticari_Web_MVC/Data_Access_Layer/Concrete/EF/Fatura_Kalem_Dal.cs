using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Concrete.EF
{
    public class Fatura_Kalem_Dal
    {
        Context c = new Context();

        public void Fatura_Kalem_Ekle(Fatura_Kalem u)
        {
            c.fatura_Kalems.Add(u);
            c.SaveChanges();

        }
        public void Fatura_Kalem_Guncelle()
        {
            c.SaveChanges();
        }

        public List<Fatura_Kalem> Fatura_Kalem_Listele()
        {
            return c.fatura_Kalems.ToList();
        }

        public void Fatura_Kalem_Sil(int id)
        {
            var a = Fatura_Kalem_Getir(id);
            c.fatura_Kalems.Remove(a);
            c.SaveChanges();

        }

        public Fatura_Kalem Fatura_Kalem_Getir(int id)
        {
            return c.fatura_Kalems.Find(id);
        }

        public List<Fatura_Kalem> Fatura_Kalem_List(int id)
        {
            return c.fatura_Kalems.Where(x => x.Fatura_Kalem_Id == id).ToList();
        }
    }
}
