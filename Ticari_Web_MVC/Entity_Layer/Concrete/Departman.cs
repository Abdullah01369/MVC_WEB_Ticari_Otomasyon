using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Departman
    {
        [Key]
        public int Departman_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Departman_Ad { get; set; }

        public ICollection<Personel> personels { get; set; }
    }
}
