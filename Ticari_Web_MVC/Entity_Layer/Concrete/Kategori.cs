using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Kategori
    {
        [Key]
        public int Kategori_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Kategori_Ad { get; set; }
        public ICollection<Urun> uruns { get; set; } // bir kategoride birden fazla urun olabilir
    }
}
