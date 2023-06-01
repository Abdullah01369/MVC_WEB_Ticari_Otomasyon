using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Mesaj
    {
        [Key]
        public int Mesaj_Id { get; set; }
        [StringLength(100)]
        public string Alici { get; set; }
        [StringLength(100)]
        public string Gonderici { get; set; }
        [StringLength(500)]
        public string Icerik { get; set; }
        [StringLength(100)]
        public string Konu { get; set; }
        public DateTime Tarih { get; set; }
    }
}
