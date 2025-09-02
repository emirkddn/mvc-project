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
                new Product { Name = "iPhone 15", Description = "256GB, AMOLED ekran, 48MP kamera", Price = 28000, Stock = 30, IsApproved = true, CategoryId = 1, IsHome = true, Image="1.jpg" },
                new Product { Name = "Samsung Galaxy S24", Description = "512GB, Dynamic AMOLED, 108MP kamera", Price = 26000, Stock = 25, IsApproved = true, CategoryId = 1, IsHome = true, Image="1.jpg" },
                new Product { Name = "Xiaomi 14 Pro", Description = "256GB, AMOLED ekran, 50MP kamera", Price = 18000, Stock = 40, IsApproved = true, CategoryId = 1, IsHome = true, Image="1.jpg" },

                // Bilgisayarlar (CategoryId = 2)
                new Product { Name = "MacBook Pro 16", Description = "M2 Pro, 16GB RAM, 1TB SSD", Price = 65000, Stock = 15, IsApproved = true, CategoryId = 2, IsHome = true, Image="2.jpg" },
                new Product { Name = "Dell XPS 15", Description = "Intel i7, 16GB RAM, 512GB SSD, RTX 4050", Price = 45000, Stock = 20, IsApproved = true, CategoryId = 2, IsHome = true, Image="2.jpg" },
                new Product { Name = "Asus ROG Strix", Description = "32GB RAM, 1TB SSD, RTX 4070, oyun laptopu", Price = 55000, Stock = 12, IsApproved = true, CategoryId = 2, IsHome = true, Image="2.jpg" },

                // Kameralar (CategoryId = 3) 
                new Product { Name = "Canon EOS R6", Description = "20MP, 4K video, full frame", Price = 35000, Stock = 10, IsApproved = true, CategoryId = 3, IsHome = true, Image="3.jpg" },
                new Product { Name = "Nikon Z7 II", Description = "45MP, 4K video, full frame", Price = 40000, Stock = 8, IsApproved = true, CategoryId = 3, IsHome = true, Image="3.jpg" },
                new Product { Name = "Sony A7 IV", Description = "33MP, 4K video, full frame", Price = 38000, Stock = 9, IsApproved = true, CategoryId = 3, IsHome = true, Image="3.jpg" },

                // Kulaklıklar (CategoryId = 4)
                new Product { Name = "Sony WH-1000XM5", Description = "Aktif Gürültü Engelleme, 30 saat pil", Price = 4500, Stock = 50, IsApproved = true, CategoryId = 4, IsHome = true, Image="4.jpg" },
                new Product { Name = "Bose QuietComfort 45", Description = "Aktif Gürültü Engelleme, rahat tasarım", Price = 4200, Stock = 40, IsApproved = true, CategoryId = 4, IsHome = true, Image="4.jpg" },
                new Product { Name = "Apple AirPods Max", Description = "Kablosuz, yüksek kaliteli ses, konforlu", Price = 6500, Stock = 30, IsApproved = true, CategoryId = 4, IsHome = true, Image="4.jpg" }
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
