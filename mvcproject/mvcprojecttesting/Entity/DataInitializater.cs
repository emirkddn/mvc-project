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
                new Category(){Name = "Telefon", Description = "Telefon ürünleri"},
                new Category(){Name = "Bilgisayar", Description = "Bilgisayar ürünleri"},
                new Category(){Name = "Kamera", Description = "Kamera ürünleri"},
                new Category(){Name = "Kulaklık", Description = "Kulaklık ürünleri"},
                new Category(){Name = "Beyaz Eşya", Description = "Beyaz ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                // Telefonlar (CategoryId = 1)
                new Product { Name = "iPhone 15", Description = "256GB depolama kapasitesi, yüksek çözünürlüklü AMOLED ekran, gelişmiş 48MP ana kamera, iOS işletim sistemi ve uzun pil ömrü ile premium bir akıllı telefon deneyimi sunar.", Price = 28000, Stock = 30, IsApproved = true, CategoryId = 1, IsHome = true, Image="1.jpg" },
                new Product { Name = "Samsung Galaxy S24", Description = "512GB geniş depolama alanı, Dynamic AMOLED ekran teknolojisi, etkileyici 108MP kamera, güçlü işlemci ve Android ekosistemi ile performans ve tasarımı bir arada sunar.", Price = 26000, Stock = 25, IsApproved = true, CategoryId = 1, IsHome = true, Image="1.jpg" },
                new Product { Name = "Xiaomi 14 Pro", Description = "256GB depolama, AMOLED ekran, gelişmiş 50MP kamera, yüksek performanslı işlemci ve uzun süreli batarya ile fiyat-performans açısından öne çıkan akıllı telefon.", Price = 18000, Stock = 40, IsApproved = true, CategoryId = 1, IsHome = true, Image="1.jpg" },

                // Bilgisayarlar (CategoryId = 2)
                new Product { Name = "MacBook Pro 16", Description = "Apple M2 Pro çip ile güçlendirilmiş, 16GB RAM ve 1TB SSD depolama kapasitesine sahip, profesyonel işler ve yüksek performans gerektiren uygulamalar için tasarlanmış premium dizüstü bilgisayar.", Price = 65000, Stock = 15, IsApproved = true, CategoryId = 2, IsHome = true, Image="2.jpg" },
                new Product { Name = "Dell XPS 15", Description = "Intel i7 işlemci, 16GB RAM, 512GB SSD ve RTX 4050 ekran kartı ile güçlü donanıma sahip, hem iş hem de multimedya kullanımı için ideal bir dizüstü bilgisayar.", Price = 45000, Stock = 20, IsApproved = true, CategoryId = 2, IsHome = true, Image="2.jpg" },
                new Product { Name = "Asus ROG Strix", Description = "32GB RAM, 1TB SSD depolama ve RTX 4070 ekran kartı ile donatılmış, oyun severler için tasarlanmış yüksek performanslı oyuncu laptopu. Güçlü soğutma sistemiyle uzun süreli oyun deneyimi sağlar.", Price = 55000, Stock = 12, IsApproved = true, CategoryId = 2, IsHome = true, Image="2.jpg" },

                // Kameralar (CategoryId = 3) 
                new Product { Name = "Canon EOS R6", Description = "20MP çözünürlük, 4K video çekim desteği ve full frame sensör özellikleri ile profesyonel fotoğrafçılar için geliştirilmiş güçlü bir aynasız fotoğraf makinesi.", Price = 35000, Stock = 10, IsApproved = true, CategoryId = 3, IsHome = true, Image="3.jpg" },
                new Product { Name = "Nikon Z7 II", Description = "45MP yüksek çözünürlük, 4K video kaydı ve full frame sensör özellikleriyle detaylı ve kaliteli çekimler için profesyonel seviyede bir aynasız fotoğraf makinesi.", Price = 40000, Stock = 8, IsApproved = true, CategoryId = 3, IsHome = true, Image="3.jpg" },
                new Product { Name = "Sony A7 IV", Description = "33MP çözünürlük, 4K video desteği, gelişmiş otomatik odaklama sistemi ve full frame sensörü ile hem video hem de fotoğraf çekimlerinde üst düzey performans sunar.", Price = 38000, Stock = 9, IsApproved = true, CategoryId = 3, IsHome = true, Image="3.jpg" },

                // Kulaklıklar (CategoryId = 4)
                new Product { Name = "Sony WH-1000XM5", Description = "Aktif gürültü engelleme teknolojisi, 30 saatlik uzun pil ömrü, kablosuz kullanım ve üstün ses kalitesi ile müzik severler için konforlu bir kulaklık.", Price = 4500, Stock = 50, IsApproved = true, CategoryId = 4, IsHome = true, Image="4.jpg" },
                new Product { Name = "Bose QuietComfort 45", Description = "Aktif gürültü engelleme özelliği, ergonomik ve rahat tasarımı, uzun pil ömrü ve dengeli ses performansı ile günlük kullanım için mükemmel bir tercih.", Price = 4200, Stock = 40, IsApproved = true, CategoryId = 4, IsHome = true, Image="4.jpg" },
                new Product { Name = "Apple AirPods Max", Description = "Kablosuz bağlantı, yüksek kaliteli ses çıkışı, Apple ekosistemi ile tam uyumlu kullanım ve konforlu tasarımıyla premium bir kulak üstü kulaklık deneyimi sunar.", Price = 6500, Stock = 30, IsApproved = true, CategoryId = 4, IsHome = true, Image="4.jpg" }
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
