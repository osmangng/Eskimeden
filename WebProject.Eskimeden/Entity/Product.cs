using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebProject.Eskimeden.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Stok")]
        public int Stock { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("Anasayfa Görünürlüğü")]
        public bool IsHome { get; set; }
        [DisplayName("Ürün Onayı")]
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category{ get; set; }
    }
}