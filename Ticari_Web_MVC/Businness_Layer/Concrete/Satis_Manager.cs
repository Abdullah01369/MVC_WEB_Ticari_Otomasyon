using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class Satis_Manager
    {
        Satis_Dal sd = new Satis_Dal();
        public void Satis_Hareket_Ekle(Satis_Hareket u)   
        {
            sd.Satis_Hareket_Ekle(u);

        }
        public void Satis_Hareket_Guncelle()
        {
            sd.Satis_Hareket_Guncelle();
        }

        public List<Satis_Hareket> Satis_Hareket_Listele()
        {
            return sd.Satis_Hareket_Listele();
        }

        public void Satis_Hareket_Sil(int id)
        {
            sd.Satis_Hareket_Sil(id);

        }

        public Satis_Hareket Satis_Hareket_Getir(int id)
        {
            return sd.Satis_Hareket_Getir(id);
        }
    }
}
