using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Gider
    {
        [Key]
        public int Gider_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Gider_Aciklama { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public DateTime Tarih { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public decimal Tutar { get; set; }
    }
}
