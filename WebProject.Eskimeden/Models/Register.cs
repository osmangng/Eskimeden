using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProject.Eskimeden.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız:")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız:")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adınız:")]
        public string Username { get; set; }

        [Required]
        [DisplayName("E-posta Adresiniz:")]
        [EmailAddress(ErrorMessage ="Eposta Adresinizi doğru giriniz.")] 
        public string Email { get; set; }

        [Required]
        [DisplayName("Parolanız:")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Parola Tekrar:")]
        [Compare("Password",ErrorMessage="Şifreleriniz uyuşmuyor")]
        public string Repassword { get; set; }
    }
}