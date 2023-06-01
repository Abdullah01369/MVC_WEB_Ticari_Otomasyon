using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
  public  class Sehir
    {
        [Key]
        public int Sehir_Id { get; set; }
        [Required]
        public string Sehir_No { get; set; }
        [Required]
        public string Sehir_Ad { get; set; }


        public ICollection<Cari> caris { get; set; }
    }
}
