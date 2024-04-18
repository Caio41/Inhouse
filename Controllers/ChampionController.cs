using Microsoft.AspNetCore.Mvc;

namespace Inhouse.Controllers
{
    public class ChampionController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
