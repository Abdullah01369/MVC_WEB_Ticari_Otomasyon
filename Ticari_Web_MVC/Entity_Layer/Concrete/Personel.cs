using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
  public class Personel
    {
        [Key]
        public  int  Personel_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Personel_Ad { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Personel_Soyad { get; set;}
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Personel_Gorsel { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Personel_Mail { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Personel_Sifre { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Personel_Kayit_Tarih { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Personel_Yetki { get; set; }

        public int Departman_Id { get; set; }
        public virtual Departman departman { get; set; }

        public ICollection<Satis_Hareket> satis_Harekets { get; set; }

    }
}
