using Inhouse.Data;
using Inhouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inhouse.Controllers
{
    public class JogadorController : Controller
    {
        private readonly AppDbContext _db;

        public JogadorController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            IEnumerable<Jogador> jogadoresList = _db.Jogadores.ToList();
            return View(jogadoresList);
        }

        public IActionResult Ranking()
        {

            IEnumerable<Jogador> jogadoresList = _db.Jogadores.OrderByDescending(j => j.Wins).ToList();
            return View(jogadoresList);
        }
    }
}
