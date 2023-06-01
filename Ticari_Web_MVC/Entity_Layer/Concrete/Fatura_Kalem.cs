using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Fatura_Kalem
    {
        [Key]
        public int Fatura_Kalem_Id { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public int Miktar { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public decimal  Birim_Fiyat { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public decimal Tutar { get; set; }


        public int Fatura_Id { get; set; }
        public virtual Fatura fatura { get; set; }
    }
}
