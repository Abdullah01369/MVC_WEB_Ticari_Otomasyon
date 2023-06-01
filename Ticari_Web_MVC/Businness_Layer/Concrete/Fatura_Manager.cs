using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
   public class Fatura_Manager
    {
        Fatura_Dal fd = new Fatura_Dal();

        public void Fatura_Ekle(Fatura u)
        {
            fd.Fatura_Ekle(u);

        }
        public void Fatura_Guncelle()
        {
            fd.Fatura_Guncelle();
        }

        public List<Fatura> Fatura_Listele()
        {
            return fd.Fatura_Listele();
        }

        public void Fatura_Sil(int id)
        {
            fd.Fatura_Sil(id);

        }

        public Fatura Fatura_Getir(int id)
        {
            return fd.Fatura_Getir(id);
        }
        public List<Fatura_Kalem> Fatura_Kalem_List(int id)
        {
            return fd.Fatura_Kalem_List(id);
        }
    }
}
