using Microsoft.AspNetCore.Mvc;

namespace Inhouse.Controllers
{
    public class JogadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
