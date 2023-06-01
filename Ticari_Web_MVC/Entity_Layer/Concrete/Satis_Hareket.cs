using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
  public  class Satis_Hareket
    {   [Key]
        public int Satis_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public DateTime Tarih { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public int Adet { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public decimal Fiyat { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public decimal Toplam_Tutar { get; set; }



        public int Personel_Id { get; set; }
        public virtual Personel Personel { get; set; }

        

        public int Urun_Id { get; set; }
        public virtual Urun Uruns { get; set; }

        public int Cari_Id { get; set; }
        public virtual Cari Cari { get; set; }



    }
}
