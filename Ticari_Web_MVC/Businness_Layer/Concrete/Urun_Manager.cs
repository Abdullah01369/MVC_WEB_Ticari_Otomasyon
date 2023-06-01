using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
   public class Urun_Manager
    {
        Urun_Dal ud = new Urun_Dal();

        public void Urun_Ekle(Urun u)
        {
            ud.Urun_Ekle(u);

        }
        public void Urun_Guncelle()
        {
            ud.Urun_Guncelle();
        }

        public List<Urun> Urun_Listele()
        {
            return ud.Urun_Listele();
        }

        public void Urun_Sil(int id)
        {
            ud.Urun_Sil(id);

        }

        public Urun Urun_Getir(int id)
        {
            return ud.Urun_Getir(id);
        }
    }
}
