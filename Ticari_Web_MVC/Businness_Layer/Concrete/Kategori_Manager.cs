using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class Kategori_Manager
    {
        Kategori_Dal kd = new Kategori_Dal();

        public void Kategori_Ekle(Kategori k)
        {
            kd.Kategori_Ekle(k);
        }
        public void Kategori_Guncelle()
        {
            kd.Kategori_Guncelle();
        }

        public List<Kategori> Kategori_Listele()
        {
            return kd.Kategori_Listele();
        }

        public void Kategori_Sil(int id)
        {
            kd.Kategori_Sil(id);
        }
        public Kategori Kategori_Getir(int id)
        {
            return kd.Kategori_Getir(id);
        }
    }
}
