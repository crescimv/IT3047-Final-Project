using Microsoft.AspNetCore.Mvc;
using Final_Project_Hobbies.Data;

namespace Final_Project_Hobbies.Controllers
{
    public class GamesController : Controller
    {
        private readonly HobbyContext _context;

        public GamesController(HobbyContext context)
        {
            _context = context;
        }

        public IActionResult List() => View();

        public IActionResult Database()
        {
            var games = _context.Games.ToList();
            return View(games);
        }
    }
}
