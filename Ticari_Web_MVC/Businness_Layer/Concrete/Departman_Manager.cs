using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
   public class Departman_Manager
    {
        Departman_Dal dd = new Departman_Dal();

        public void Departman_Ekle(Departman k)
        {
            dd.Departman_Ekle(k);
        }
        public void Departman_Guncelle()
        {
            dd.Departman_Guncelle();
        }

        public List<Departman> Departman_Listele()
        {
            return dd.Departman_Listele();
        }

        public void Departman_Sil(int id)
        {
            dd.Departman_Sil(id);

        }

        public Departman Departman_Getir(int id)
        {
            return dd.Departman_Getir(id);
        }
    }
}
