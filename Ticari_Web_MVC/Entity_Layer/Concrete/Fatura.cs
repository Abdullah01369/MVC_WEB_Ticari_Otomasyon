using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Fatura
    {
        [Key]
        public int Fatura_Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Fatura_Seri_No { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Fatura_Sira_No { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public DateTime Tarih { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Vergi_Dairesi { get; set; }

        [Column(TypeName = "char")]
        [StringLength(5)]
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Saat { get; set; }

        public int Cari_Id { get; set; }
        public virtual Cari Cari { get; set; }

       

        public decimal Toplam { get; set; }

        public ICollection<Fatura_Kalem> fatura_Kalems { get; set; }
    }
}
