using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
