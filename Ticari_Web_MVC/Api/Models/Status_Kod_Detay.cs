using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Status_Kod_Detay
    {
        public enum mesaj_kod
        {
            [Description("Başarılı işlem")]
            basarili=100,
            [Description("Başarısız işlem")]
            basarisiz =200,
            [Description("Hatalı işlem")]
            hata =300,
            [Description("Listeleme Hatası")]
            listeleme_hata =301,
            [Description("username or passord is wrong")]
            Yetki_Hata = 400


        }
    }
}