using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticari_Web_MVC.Models
{
    public class Login_Model
    {

        public int Login_Model_Id { get; set; }
        public Personel Personel { get; set; }
        public Cari Cari { get; set; }
    }
}