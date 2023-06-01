using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
   public class Personel_Manager
    {
        Personel_Dal pd = new Personel_Dal();
        public void Personel_Ekle(Personel u)
        {
            
            pd.Personel_Ekle(u);

        }
        public void Personel_Guncelle()
        {
            pd.Personel_Guncelle();
        }

        public List<Personel> Personel_Listele()
        {
            return pd.Personel_Listele();
        }

        public void Personel_Sil(int id)
        {
            pd.Personel_Sil(id);

        }

        public Personel Personel_Getir(int id)
        {
            return pd.Personel_Getir(id);
        }
        public List<Personel> Personel_Listele_Departman(int id)
        {
            return pd.Personel_Listele_Departman(id);
        }
        public List<Satis_Hareket> Personel_Satis_Liste(int id)
        {
            return pd.Personel_Satis_Liste(id);
        }

        public Personel Personel_Giris(Personel p)
        {
           var user= pd.Personel_Giris(p);
            return user;
        }
        public Personel Personel_Getir_Mail(string mail)
        {
            var p = pd.Personel_Getir_Mail(mail);
            return p;
        }
    }
}
