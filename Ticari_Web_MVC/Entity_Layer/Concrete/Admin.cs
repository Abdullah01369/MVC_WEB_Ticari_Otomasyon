using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Admin
    {
        [Key]

        public int Admin_Id { get; set; }
        
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Admin_Ad { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Admin_Soyad { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Admin_Mail { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Admin_Sifre { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public DateTime Admin_Kayit_Tarih { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Admin_Yetki { get; set; }

    }
}
