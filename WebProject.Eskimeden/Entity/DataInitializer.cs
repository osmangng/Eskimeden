using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProject.Eskimeden.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name="Kamera", Description="Kamera Ürünleri"},
                new Category(){ Name="Beyaz Eşya", Description="Beyaz Eşya Ürünleri"},
                new Category(){ Name="Bilgisayar", Description="Bilgisayar Ürünleri"},
                new Category(){ Name="Telefon", Description="Telefon Ürünleri"},
                new Category(){ Name="Elektronik", Description="Elektronik Eşyalar Ürünleri"},


            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                
               // new Product(){ Name="Arzum OK004 Okka Minio Türk Kahvesi Makinesi", Description="Güç: 480 WattRenk: BakırSusuz\n Çalışma Emniyeti: 300 ml(4 fincan)\nOtomatik Kapanma: VarRezistans \nTipi: Gizli ", Price=289.90 , Stock=42, IsApproved=true,CategoryId=3,Image="KahveMakinasi.jpg"},
               // new Product(){ Name="Lenovo Ideapad 330S-15IKB", Description="Intel Core i5 8250U 8GB 256GB SSD AMD Radeon 535 Freedos 15,6 FHD Taşınabilir Bilgisayar 81F500QMTX", Price=4999 , Stock=3, IsApproved=true,CategoryId=2,Image="LenovoIdepadV330.jpg"},
               // new Product(){ Name="Lenovo Legion Y530-15ICH", Description="Intel Core i7 8750H 16GB 2TB + 256GB SSD GTX1050 Ti Windows 10 Home 15,6 FHD Taşınabilir Bilgisayar 81FV00L5TX", Price=9599.00 , Stock=41, IsApproved=true,CategoryId=2,IsHome=true, Image="LenovoLegionY5330.jpg"},
               // new Product(){ Name="Samsung Galaxy Tab 3 Lite T113 8GB 7 Siyah Tablet", Description="Samsung Galaxy Tab 3 Lite T113 8GB 7 Siyah Tablet", Price= 589.99, Stock=34, IsApproved=true,CategoryId=2,Image="SamsungTab.jpg"},
               // new Product(){ Name="Apple iPad 6.Nesil 32GB 9.7", Description="Bir bilgisayar gibi. Ama hiçbir bilgisayar gibi değil.Eğer bilgisayar bugün icat edilseydi, nasıl olurdu?", Price=2199.90 , Stock=50, IsApproved=true,CategoryId=2,IsHome=true, Image="AppleiPad6.jpg"},
               // new Product(){ Name="ACER AN515", Description="CORE İ7 8750H 2.2GHZ 8GB 1TB 128GB SSD 15.6 inç GTX1050TI 4GB W10", Price= 7399.99, Stock= 6, IsApproved= true, CategoryId=3, IsHome=true,Image="aceran515.jpg"},
               // new Product(){ Name="ASUS UX362FA", Description="CORE İ7 8565U 1.8GHZ 16GB RAM 512GB SSD INT TOUCH 13.3 inç W10", Price= 10999.99, Stock= 5, IsApproved= true, CategoryId=3, IsHome=true,Image="asusux362fa.jpg"},

new Product(){ Name="MSI GE75", Description="RAIDER CORE İ7 9750H 2.6GHZ 32GB 256GB SSD 1TB 17.3 inç RTX 2070 8GB W10", Price= 20599.99, Stock= 3, IsApproved= true, CategoryId=3, IsHome=true,Image="msige75.jpg"},

new Product(){ Name="LENOVO IDEAPAD 330S", Description="CORE İ3 7020U 2.3GHZ-4GB-128GB SSD-14 inç-INT-W10", Price= 3599.99, Stock= 12, IsApproved= true, CategoryId=3, IsHome=true,Image="lenovoideapad330s.jpg"},

new Product(){ Name="LENOVO LEGION Y530", Description="CORE İ5 8300H 2.3GHZ-16GB-1TB+128SSD-15.6 inç-GTX1050 4GB-W10", Price= 7999.99, Stock= 4, IsApproved= true, CategoryId=3, IsHome=true,Image="lenovolegiony530.jpg"},

new Product(){ Name="DELL ALIENWARE 15", Description="CORE İ7 8750H 2.2GHZ-16GB-512GBSSD+1TB-15.6 inç-RTX2070 8GB-W10", Price= 18999.99, Stock= 2, IsApproved= true, CategoryId=3, IsHome=true,Image="dellalienware15.jpg"},

new Product(){ Name="HP PAVILION15-CX0032NT", Description="COREİ7 8750H 2.2GHZ-16GB-1TB+256GBSSD-15.6 inç-GTX1050Ti-W10", Price= 9899.99, Stock= 4, IsApproved= true, CategoryId=3, IsHome=true,Image="hppavilioncx0032nt.jpg"},

new Product(){ Name="APPLE MACBOOK AIR MQD32TU/A", Description="CORE İ5 1.8GHZ-8GB-128GBSSD-13.3 inç-INT NOTEBOOK", Price= 5699.99, Stock= 6, IsApproved= true, CategoryId=3, IsHome=true,Image="macbookairmqd32tu.jpg"},

new Product(){ Name="APPLE MACBOOK PRO MPXT2TU/A", Description="CORE İ5 2.3GHZ-8GB-256GBSSD-RETINA 13 inç-INT-SPACE GREY", Price= 9699.99, Stock= 4, IsApproved= true, CategoryId=3, IsHome=true,Image="macbookprompxt2tu.jpg"},

new Product(){ Name="MSI GS75 STEALTH", Description="CORE İ7 8750H 2.2GHZ-32GB-256GB SSD-17.3 inç-RTX 2070 8GB-W10", Price= 21199.99, Stock= 2, IsApproved= true, CategoryId=3, IsHome=true,Image="msigs75.jpg"},

new Product(){ Name="SAMSUNG QE 75Q90RA", Description="75 inç 189 CM 4K UHD SMART QLED TV,DAHİLİ UYDU ALICI", Price= 37999.99, Stock= 3, IsApproved= true, CategoryId=5, IsHome=true,Image="samsungqe75q90ra.jpg"},

new Product(){ Name="SAMSUNG UE 55NU7400", Description="55 inç 138 CM 4K UHD SMART TV,DAHİLİ UYDU ALICI", Price= 4799.99, Stock= 14, IsApproved= true, CategoryId=5, IsHome=true,Image="samsungue55nu7400.jpg"},

new Product(){ Name="SAMSUNG QE 65Q70RA", Description="65 inç 163 CM 4K UHD SMART QLED TV,DAHİLİ UYDU ALICI", Price= 14999.99, Stock= 7, IsApproved= true, CategoryId=5, IsHome=true,Image="samsungqe65q70ra.jpg"},

new Product(){ Name="LG 75UK6500", Description="75 inç 191 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI", Price= 11999.99, Stock= 6, IsApproved= true, CategoryId=5, IsHome=true,Image="lg75uk6500.jpg"},

new Product(){ Name="LG 55UK7550", Description="55 inç 140 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI", Price= 5799.99, Stock= 15, IsApproved= true, CategoryId=5, IsHome=true,Image="lg55uk7550.jpg"},

new Product(){ Name="LG 86UK6500", Description="86 inç 219 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI", Price= 19999.99, Stock= 4, IsApproved= true, CategoryId=5, IsHome=true,Image="lg86uk6500.jpg"},

new Product(){ Name="PHILIPS 43PFS5503", Description="43 inç 108 CM FHD TV,DAHİLİ UYDU ALICI", Price= 2599.99, Stock= 10, IsApproved= true, CategoryId=5, IsHome=true,Image="philips43pfs5503.jpg"},

new Product(){ Name="PHILIPS 55PUS7503", Description="55 inç 139 CM 4K UHD ANDROID SMART TV,DAHİLİ UYDU ALICI", Price= 5599.99, Stock= 7, IsApproved= true, CategoryId=5, IsHome=true,Image="philips55pus7503.jpg"},

new Product(){ Name="SONY 55XF7596", Description="55 inç 139 CM 4K UHD ANDROID SMART TV,DAHİLİ UYDU ALICI", Price= 8299.99, Stock= 5, IsApproved= true, CategoryId=5, IsHome=true,Image="sony55xf7596.jpg"},

new Product(){ Name="SONY 75XG8596", Description="75 inç 189 CM 4K UHD SMART TV,DAHİLİ UYDU ALICI", Price= 19999.99, Stock= 3, IsApproved= true, CategoryId=5, IsHome=true,Image="sony75xg8596.jpg"},

new Product(){ Name="SAMSUNG GALAXY S10 PLUS", Description="128 GB AKILLI TELEFON", Price= 7499.99, Stock= 10, IsApproved= true, CategoryId=4, IsHome=true,Image="samsunggalaxys10plus.jpg"},

new Product(){ Name="SAMSUNG GALAXY A70", Description="128 GB AKILLI TELEFON", Price= 3499.99, Stock= 5, IsApproved= true, CategoryId=4, IsHome=true,Image="samsunggalaxya70.jpg"},

new Product(){ Name="SAMSUNG GALAXY S10", Description="128 GB AKILLI TELEFON", Price= 6599.99, Stock= 12, IsApproved= true, CategoryId=4, IsHome=true,Image="samsunggalaxys10.jpg"},

new Product(){ Name="SAMSUNG GALAXY NOTE 9", Description="128 GB AKILLI TELEFON ", Price= 5899.99, Stock= 3, IsApproved= true, CategoryId=4, IsHome=true,Image="samsunggalaxynote9.jpg"},

new Product(){ Name="IPHONE XS MAX", Description="512 GB AKILLI TELEFON", Price= 13999.99, Stock= 5, IsApproved= true, CategoryId=4, IsHome=true,Image="iphonexsmax512.jpg"},

new Product(){ Name="IPHONE XS", Description="256 GB AKILLI TELEFON", Price= 10699.99, Stock= 7, IsApproved= true, CategoryId=4, IsHome=true,Image="iphonexs256.jpg"},

new Product(){ Name="IPHONE X", Description="64 GB AKILLI TELEFON", Price= 7899.99, Stock= 4, IsApproved= true, CategoryId=4, IsHome=true,Image="iphonex64.jpg"},

new Product(){ Name="IPHONE 8 PLUS", Description="64 GB AKILLI TELEFON", Price= 5899.99, Stock= 2, IsApproved= true, CategoryId=4, IsHome=true,Image="iphone8plus.jpg"},

new Product(){ Name="HUAWEI MATE 20 PRO", Description="128 GB AKILLI TELEFON", Price= 5999.99, Stock= 4, IsApproved= true, CategoryId=4, IsHome=true,Image="huaweimate20pro.jpg"},

new Product(){ Name="XIAOMI Mİ 8 LITE", Description="64 GB AKILLI TELEFON", Price= 2499.99, Stock= 3, IsApproved= true, CategoryId=4, IsHome=true,Image="xiaomimi8.jpg"},

new Product(){ Name="PHILIPS FC9751/07", Description="POWERPRO MAX TURBO BAŞLIKLI TORBASIZ ELEKTRİKLİ SÜPÜRGE", Price= 1499.99, Stock= 4, IsApproved= true, CategoryId=2, IsHome=true,Image="philipsfc9751.jpg"},

new Product(){ Name="PHILIPS HPS910/00", Description="PRO PRESTIGE 2100 W. AC MOTORLU PROFESYONEL SAÇ KURUTMA MAKİNE", Price= 459.99, Stock= 3, IsApproved= true, CategoryId=2, IsHome=true,Image="philipshps910.jpg"},

new Product(){ Name="DUCATI BY ARZUM AR5505", Description="STEERING SAÇ KESME MAKİNESİ", Price= 229.99, Stock= 2, IsApproved= true, CategoryId=2, IsHome=true,Image="ducatibyarzum.jpg"},

new Product(){ Name="GOLDMASTER GM7924", Description="ALASKA BUHARLI VANTİLATÖR", Price= 699.99, Stock= 4, IsApproved= true, CategoryId=2, IsHome=true,Image="goldmastergm7924.jpg"},

new Product(){ Name="PHILIPS GC4518/30", Description="AZUR PERFORMER PLUS BUHARLI ÜTÜ", Price= 379.99, Stock= 5, IsApproved= true, CategoryId=2, IsHome=true,Image="philipsgc4518.jpg"},

new Product(){ Name="BRAUN D 12", Description="CROSS ACTION ORAL B ŞARJLI DİŞ FIRÇASI", Price= 99.99, Stock= 6, IsApproved= true, CategoryId=2, IsHome=true,Image="braund12.jpg" },

new Product() { Name = "TEFAL KÖPÜKLÜM", Description = "TÜRK KAHVE MAKİNESİ (SİYAH)", Price = 549.99, Stock = 2, IsApproved = true, CategoryId = 2, IsHome = true, Image = "tefalkopuklum.jpg" },

new Product() { Name = "REMINGTON S6606 CONFIDENCE", Description = "2'Sİ1 ARADA BUKLE MAŞASI VE SAÇ DÜZLEŞTİRİCİ", Price = 699.99, Stock = 4, IsApproved = true, CategoryId = 2, IsHome = true, Image = "remingtons6606.jpg" },

new Product() { Name = "FAKIR WARMY", Description = "FANLI ISITICI (AÇIK GRİ)", Price = 299.99, Stock = 3, IsApproved = true, CategoryId = 2, IsHome = true, Image = "fakirwarmy.jpg" },

new Product() { Name = "UFO MICATRONIC/23", Description = "UZAKTAN KUMANDALI İNFRARED ISITICI (DEVRİLME EMNİYETLİ-2300W)", Price = 669.99, Stock = 2, IsApproved = true, CategoryId = 2, IsHome = true, Image = "ufomicatronic.jpg" },
        };
            
            foreach (var product in urunler)
            {
                context.Products.Add(product);

            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}