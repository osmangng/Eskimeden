using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Eskimeden.Models
{
    public class ShippingDetails
    {
        //Ad soyad bilgisi
        //Login olan kullanıcının otomatik doldurulacak
        //Login olmaya kullanıcı kendi dolduracak.
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen Adres tanımını giriniz.")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "Lütfen Adres giriniz.")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lütfen Şehir giriniz.")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lütfen Semt giriniz.")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Lütfen Mahallle  giriniz.")]
        public string Mahalle { get; set; }

        [Required(ErrorMessage = "Lütfen Posta kodunu giriniz.")]
        public string PostaKodu { get; set; }
    }
    
}