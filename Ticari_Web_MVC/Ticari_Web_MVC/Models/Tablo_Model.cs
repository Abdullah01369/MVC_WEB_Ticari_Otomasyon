using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ticari_Web_MVC.Models
{
    public class Tablo_Model
    {
        [Key]
        public int Tablo_Model_Id { get; set; }
        public List<Sehir> Sehir { get; set; }
        public int Sayi { get; set; }
    }
}