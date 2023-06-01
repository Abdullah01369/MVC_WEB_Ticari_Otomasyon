using Api.Models;
using Api.Models.Request;
using Api.Models.Response;
using Data_Access_Layer.Concrete.EF;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    //     public Urun_Liste_Response Urun_Listele(string a, string b)  vermemiz halinde  ERİŞİM MANUEL İCİN= " .../api/Urun/Urun_Listele?a=20&b=30" 

    public class UrunController : ApiController
    {
        Urun_Dal ud = new Urun_Dal();


        [HttpGet]
        public Urun_Liste_Response Urun_Listele( Urun_Liste_Request _Liste_Request)
        {
            Urun_Liste_Response ur;
            try
            {
                if (_Liste_Request.yetki.User_Name == "admin" && _Liste_Request.yetki.Password == "123")
                {
                    try
                    {
                        var veri = ud.Urun_Listele();

                        var liste = veri.Select(x => new
                        {
                            x.Urun_Ad,
                            x.Urun_Eklenme_Tarih,
                            x.Stok,
                            x.Satis_Fiyat,
                            x.Alis_Fiyat
                        }).ToList()
                       .Select(x => new Urun()
                       {
                           Urun_Ad = x.Urun_Ad,
                           Urun_Eklenme_Tarih = x.Urun_Eklenme_Tarih,
                           Stok = x.Stok,
                           Satis_Fiyat = x.Satis_Fiyat,
                           Alis_Fiyat = x.Alis_Fiyat
                       }).ToList();



                        return ur = new Urun_Liste_Response()
                        {
                            Statu = new Models.Attribute.Status()
                            {
                                kod = (int)Status_Kod_Detay.mesaj_kod.basarili,
                                mesaj = Status_Kod_Detay.mesaj_kod.basarili.ToString()

                            },
                            urun = liste


                        };

                    }
                    catch (Exception)
                    {

                        return ur = new Urun_Liste_Response()
                        {
                            Statu = new Models.Attribute.Status()
                            {
                                kod = (int)Status_Kod_Detay.mesaj_kod.listeleme_hata,
                                mesaj = Status_Kod_Detay.mesaj_kod.listeleme_hata.ToString()
                            }
                        };

                    }

                }

                else
                {
                    return ur = new Urun_Liste_Response()
                    {
                        Statu = new Models.Attribute.Status()
                        {
                            kod = (int)Status_Kod_Detay.mesaj_kod.Yetki_Hata,
                            mesaj = Status_Kod_Detay.mesaj_kod.Yetki_Hata.ToString()
                        }
                    };
                }




            }
            catch (Exception)
            {

                return ur = new Urun_Liste_Response()
                {
                    Statu = new Models.Attribute.Status()
                    {
                        kod = (int)Status_Kod_Detay.mesaj_kod.hata,
                        mesaj = Status_Kod_Detay.mesaj_kod.hata.ToString()
                    }
                };
            }

        }

        [HttpGet]
        public Urun Urun_Getir(int Urun_Id)
        {
            return ud.Urun_Getir(Urun_Id);
        }



        [HttpPost]
        public Urun_Response Urun_Kaydet([FromBody] Urun_Request ur)
        {
            // request ile karsıladık, response ile yanıt döndürdük.


            Urun_Response urun_Response;
            try
            {
                if (ur.yetki.User_Name == "admin" || ur.yetki.Password == "123")
                {
                    ud.Urun_Ekle(new Urun()
                    {
                        Urun_Ad = ur.urun.Urun_Ad,
                        Urun_Eklenme_Tarih = DateTime.Now,
                        Urun_Gorsel = "ornek gorsel adress",
                        Durum = true,
                        Alis_Fiyat = ur.urun.Alis_Fiyat,
                        Satis_Fiyat = ur.urun.Satis_Fiyat,
                        Stok = ur.urun.Stok,
                        Kategori_Id = ur.urun.Kategori_Id,
                        Marka_Id = ur.urun.Marka_Id



                    });
                    return urun_Response = new Urun_Response()
                    {
                        Statu = new Models.Attribute.Status()
                        {
                            kod = (int)Status_Kod_Detay.mesaj_kod.basarili,
                            mesaj = Status_Kod_Detay.mesaj_kod.basarili.ToString()

                        },
                        Urun_Id = ur.urun.Urun_Id


                    };

                }

                else
                {
                    return urun_Response = new Urun_Response()
                    {
                        Statu = new Models.Attribute.Status()
                        {
                            kod = (int)Status_Kod_Detay.mesaj_kod.Yetki_Hata,
                            mesaj = Status_Kod_Detay.mesaj_kod.Yetki_Hata.ToString()
                        }
                    };
                }
            }
            catch (Exception)
            {
                Urun_Response rp = new Urun_Response();

                return rp = new Urun_Response()
                {
                    Statu = new Models.Attribute.Status()
                    {
                        kod = (int)Status_Kod_Detay.mesaj_kod.hata,
                        mesaj = Status_Kod_Detay.mesaj_kod.hata.ToString()
                    }
                };

            }

        }
    }
}
