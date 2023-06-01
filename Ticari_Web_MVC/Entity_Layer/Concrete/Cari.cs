using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Cari
    {
        [Key]
        public int Cari_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Cari_Ad { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Cari_Soyad { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Cari_Mail { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string Cari_Sifre { get; set; }
        [Required]

        public int Sehir_Id { get; set; }
        public virtual Sehir Sehir { get; set; }

        public ICollection<Satis_Hareket> Satis_Harekets { get; set; }




    }
}
