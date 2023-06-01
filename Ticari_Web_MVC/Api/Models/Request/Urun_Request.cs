using Api.Models.Attribute;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Request
{
    public class Urun_Request
    {
        public Yetki yetki { get; set; }
        public Urun urun { get; set; }
    }
}