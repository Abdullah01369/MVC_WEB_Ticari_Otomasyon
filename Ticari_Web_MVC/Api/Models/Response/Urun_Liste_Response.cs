using Api.Models.Attribute;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Response
{
    public class Urun_Liste_Response
    {
        public Status Statu { get; set; }
        public List<Urun> urun { get; set; }
    }
}