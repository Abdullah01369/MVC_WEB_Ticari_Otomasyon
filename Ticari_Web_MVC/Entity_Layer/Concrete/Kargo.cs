using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Kargo
    {
        [Key]
        public int Kargo_Id { get; set; }
        public string Aciklama { get; set; }
        public string TakipKodu { get; set; }
        public string Personel { get; set; }
        public string Alici { get; set; }
        public bool Aktiflik { get; set; }
        public DateTime Tarih { get; set; }
        public List<Urun> Uruns { get; set; }
        public Cari Cari { get; set; }
       
    }
}
