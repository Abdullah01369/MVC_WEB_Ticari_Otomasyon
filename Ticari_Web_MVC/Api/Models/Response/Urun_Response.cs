using Api.Models.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models.Response
{
    public class Urun_Response  // işlem yapıldıgında kullanıcıya gonderilen veriler
    {
        public Status Statu { get; set; }
        public int Urun_Id { get; set; }
    }
}