using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
   public class Urun
    {
        [Key]
        public int Urun_Id { get; set; }
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        public string Urun_Ad { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public decimal Alis_Fiyat { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public decimal Satis_Fiyat { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public bool Durum { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public short Stok { get; set; }
        
        public string Urun_Gorsel { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public DateTime Urun_Eklenme_Tarih { get; set; }

        public int Kategori_Id { get; set; }  // EKLENDİ
        public int Marka_Id { get; set; }

        public virtual Kategori kategori { get; set; }  // kategori_id sqlde tutuldu
        public virtual Marka marka { get; set; }

        public ICollection<Satis_Hareket> Satis_Harekets { get; set; }
      
     

    }
}
