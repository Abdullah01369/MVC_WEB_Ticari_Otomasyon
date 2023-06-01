using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Kargo_Takip
    {
        [Key]
        public int KargoDetayid { get; set; }
        [StringLength(300)]
        public string Aciklama { get; set; }
        [StringLength(50)]
        public string TakipKodu { get; set; }
        [StringLength(50)]
        public string Personel { get; set; }
        [StringLength(50)]
        public string Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}
