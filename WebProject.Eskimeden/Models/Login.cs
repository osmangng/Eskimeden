using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProject.Eskimeden.Models
{
    public class Login
    {

        [Required]
        [DisplayName("Kullanıcı Adınız:")]
        public string Username { get; set; }

        [Required]
        [DisplayName("E-posta Adresiniz:")]
        [EmailAddress(ErrorMessage = "Eposta Adresinizi doğru giriniz.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Parolanız:")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}