using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Marka
    {
        [Key]
        public int Marka_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Marka_Ad { get; set; }

        public ICollection<Urun> uruns { get; set; }

    }
}
