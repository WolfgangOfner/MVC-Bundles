using System.Web.Mvc;
using Bundles.Models;

namespace Bundles.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult AddCustomer()
        {
            return View(new Customer());
        }

        [HttpPost]
        public JsonResult AddCustomer(Customer customer)
        {
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
    }
}