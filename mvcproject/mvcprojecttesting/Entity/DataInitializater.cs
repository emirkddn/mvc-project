using System.Collections.Generic;
using System.Data.Entity;
using mvcprojecttesting.Entity;

namespace mvcprojecttesting.Entity
{
    public class DataInitializater:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name = "Kamera", Description = "Kamera ürünleri"},
                new Category(){Name = "Bilgisayar", Description = "Bilgisayar ürünleri"},
                new Category(){Name = "Elektronik", Description = "Elektronik ürünleri"},
                new Category(){Name = "Telefon", Description = "Telefon ürünleri"},
                new Category(){Name = "Beyaz Eşya", Description = "Beyaz ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){ Name = "Smart TV", Description = "55 inç, 4K UHD, HDR, Android TV işletim sistemi, çoklu bağlantı seçenekleri", Price = 15000, Stock = 20, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "SSD Disk", Description = "1TB, NVMe, ultra hızlı veri aktarımı, uzun ömürlü", Price = 3500, Stock = 60, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "RAM 16GB", Description = "DDR4, 3200MHz, oyun ve profesyonel uygulamalar için optimize edilmiş", Price = 1200, Stock = 100, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "Gaming Mousepad", Description = "RGB aydınlatmalı, büyük boy, kaymaz yüzey, oyun için ideal", Price = 300, Stock = 80, IsApproved = true, CategoryId = 2 },
                new Product(){ Name = "Drone", Description = "4K kamera, GPS, uzun uçuş süresi ve kompakt tasarım", Price = 25000, Stock = 12, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "VR Gözlük", Description = "Yüksek çözünürlüklü, konforlu, VR oyun ve simülasyonlar için ideal", Price = 12000, Stock = 15, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "Akıllı Ev Asistanı", Description = "Sesli komut, IoT cihaz yönetimi, akıllı evler için entegre çözüm", Price = 3000, Stock = 40, IsApproved = true, CategoryId = 4 },
                new Product(){ Name = "Harici Hard Disk", Description = "2TB, USB 3.0, taşınabilir ve dayanıklı", Price = 1500, Stock = 70, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "Oyun Koltuğu", Description = "Ergonomik, uzun saatler rahat kullanım, ayarlanabilir yükseklik", Price = 4500, Stock = 30, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "Profesyonel Kamera Tripod", Description = "Hafif alüminyum, 180 derece dönebilen kafa, taşınabilir", Price = 1200, Stock = 50, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "4K Aksiyon Kamerası", Description = "Su geçirmez, geniş açılı lens, yüksek kare hızı", Price = 8000, Stock = 25, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "Kablosuz Kulaklık", Description = "Gürültü engelleme, uzun pil ömrü, konforlu tasarım", Price = 2000, Stock = 90, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "Akıllı Saat", Description = "Fitness takibi, bildirimler, uzun pil ömrü", Price = 2500, Stock = 55, IsApproved = true, CategoryId = 4 },
                new Product(){ Name = "Bluetooth Hoparlör", Description = "360 derece ses, su geçirmez, taşınabilir", Price = 800, Stock = 75, IsApproved = true, CategoryId = 1 },
                new Product(){ Name = "Dijital Fotoğraf Makinesi", Description = "24MP, 4K video, optik zoom, Wi-Fi bağlantısı", Price = 6000, Stock = 18, IsApproved = true, CategoryId = 1 }
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
