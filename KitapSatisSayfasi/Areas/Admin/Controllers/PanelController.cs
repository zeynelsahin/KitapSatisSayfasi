using Microsoft.AspNetCore.Mvc;

namespace KitapSatisSayfasi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PanelController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}