using Microsoft.AspNetCore.Mvc;

namespace PlantillaECommerce.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
