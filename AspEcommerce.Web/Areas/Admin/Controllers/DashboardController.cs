using Microsoft.AspNetCore.Mvc;

namespace AspEcommerce.Web.Areas.Admin.Controllers
{
    public class DashboardController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
