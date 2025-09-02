using System.Linq;
using System.Web.Mvc;
using mvcprojecttesting.Entity;
using System.Data.Entity;

namespace mvcprojecttesting.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        public ActionResult Index()
        {     
            return View(_context.Products.Where(i => i.IsApproved).ToList());
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
        public ActionResult List()
        {
            return View(_context.Products.Where(i => i.IsApproved).ToList());
        }
    }
}
