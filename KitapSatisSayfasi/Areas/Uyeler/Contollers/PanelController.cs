using Microsoft.AspNetCore.Mvc;

namespace KitapSatisSayfasi.Areas.Uyeler.Contollers
{
    [Area("Uyeler")]
    public class PanelController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}