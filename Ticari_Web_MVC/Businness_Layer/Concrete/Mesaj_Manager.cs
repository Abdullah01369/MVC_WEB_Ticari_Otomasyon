using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Concrete
{
   public class Mesaj_Manager
    {
        Mesaj_Dal md = new Mesaj_Dal();

        public void Mesaj_Ekle(Mesaj u)
        {
            md.Mesaj_Ekle(u);

        }
        public void Mesaj_Guncelle()
        {
            md.Mesaj_Guncelle();
        }

        public List<Mesaj> Mesaj_Listele_Mail(string mail)
        {
            return md.Mesaj_Listele_Mail_Gelen(mail);
        }

        public List<Mesaj> Mesaj_Listele_Mail_Giden(string mail)
        {
            return md.Mesaj_Listele_Mail_Giden(mail);
        }
        public void Mesaj_Sil(int id)
        {
            
            md.Mesaj_Sil(id);

        }

        public Mesaj Mesaj_Getir(int id)
        {
            return md.Mesaj_Getir(id);
        }

        public Mesaj Mesaj_Detay_Getir(int id)
        {
            return md.Mesaj_Detay_Getir(id);
        }

        public void Mesaj_Gonder(Mesaj m)
        {
            md.Mesaj_Gonder(m);
        }

    }
}
