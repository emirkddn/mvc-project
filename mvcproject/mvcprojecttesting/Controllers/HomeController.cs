using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;
using mvcprojecttesting.Entity;
using mvcprojecttesting.Models;

namespace mvcprojecttesting.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        public ActionResult Index()
        {
            var urunler = _context.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name.Length>50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                Description = i.Description.Length>50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                Price = i.Price,
                Stock = i.Stock,
                Image = i.Image ?? "unnamed.jpg",
                CategoryId = i.CategoryId,
            }).ToList();
            return View(urunler);
        }
        public ActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products.Where(i => i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                Price = i.Price,
                Stock = i.Stock,
                Image = i.Image,
                CategoryId = i.CategoryId,
            }).AsQueryable();
            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }
            return View(urunler.ToList());
        }
        public PartialViewResult GetCategories()
        { 
            return PartialView(_context.Categories.ToList());
        }

    }
}
