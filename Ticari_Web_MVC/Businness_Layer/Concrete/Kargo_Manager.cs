using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
    public class Kargo_Manager
    {
        Kargo_Dal kd = new Kargo_Dal();
        public void Kargo_Ekle(Kargo k)
        {
             kd.Kargo_Ekle(k);
        }
        public void Kargo_Guncelle()
        {
            kd.Kargo_Guncelle();
        }

        public List<Kargo> Kargo_Listele()
        {
            return kd.Kargo_Listele();
        }

        public void Kargo_Iptal(int id)
        {

            kd.Kargo_Iptal(id);
        }

        public Kargo Kargo_Getir(int id)
        {
            return kd.Kargo_Getir(id);
        }
    }
}
