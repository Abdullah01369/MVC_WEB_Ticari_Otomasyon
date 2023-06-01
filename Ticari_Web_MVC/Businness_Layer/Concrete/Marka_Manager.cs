using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
   public class Marka_Manager
    {
        Marka_Dal md = new Marka_Dal();

        public void Marka_Ekle(Marka k)
        {
            md.Marka_Ekle(k);
        }
        public void Marka_Guncelle()
        {
            md.Marka_Guncelle();
        }

        public List<Marka> Marka_Listele()
        {
            return md.Marka_Listele();
        }

        public void Marka_Sil(int id)
        {
            md.Marka_Sil(id);

        }

        public Marka Marka_Getir(int id)
        {
            return md.Marka_Getir(id);
        }
    }
}
