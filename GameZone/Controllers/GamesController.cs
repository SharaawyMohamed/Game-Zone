using GameZone.Models;
using GameZone.VMS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameDbContext context;
        public GamesController(GameDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateGame()
        {

            CreateGameVM viewmodel = new CreateGameVM()
            {
                Categories = context.Categories.Select(C=>new SelectListItem() { Value=C.Id.ToString(),Text=C.Name})
            };
            return View(viewmodel);
        }
    }
}
    