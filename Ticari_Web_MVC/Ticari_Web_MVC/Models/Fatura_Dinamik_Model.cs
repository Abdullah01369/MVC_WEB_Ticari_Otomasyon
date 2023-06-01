using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticari_Web_MVC.Models
{
    public class Fatura_Dinamik_Model
    {
        public IEnumerable<Fatura>  Fatura { get; set; }
        public IEnumerable<Fatura_Kalem> Fatura_Kalem { get; set; }
    }
}