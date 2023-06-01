using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
  public  class Fatura_Kalem_Manager
    {
        Fatura_Kalem_Dal fkd = new Fatura_Kalem_Dal();
        public void Fatura_Kalem_Ekle(Fatura_Kalem u)
        {
            fkd.Fatura_Kalem_Ekle(u); 
        }
        public void Fatura_Kalem_Guncelle()
        {
            fkd.Fatura_Kalem_Guncelle();
           
        }

        public List<Fatura_Kalem> Fatura_Kalem_Listele()
        {
            return fkd.Fatura_Kalem_Listele();
        }

        public void Fatura_Kalem_Sil(int id)
        {

            fkd.Fatura_Kalem_Sil(id);
        }

        public Fatura_Kalem Fatura_Kalem_Getir(int id)
        {
          return  fkd.Fatura_Kalem_Getir(id);
        }

        public List<Fatura_Kalem> Fatura_Kalem_Kalem_List(int id)
        {
           return fkd.Fatura_Kalem_List(id);
        }
    }
}
