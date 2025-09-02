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
            return View(_context.Products.ToList());
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}
