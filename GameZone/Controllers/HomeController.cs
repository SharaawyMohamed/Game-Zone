using GameZone.Core.Models;
using GameZone.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameZone.Controllers
{
	public class HomeController : Controller
	{
		private readonly IGamesServices _gameservice;

		public HomeController(IGamesServices gameservice)
		{
			_gameservice = gameservice;
		}

		public IActionResult Index()
		{

			return View(_gameservice.GetAllGames());
		}

		
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
