using GameZone.Core.Data;
using GameZone.Services;
using GameZone.VMS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Controllers
{
	public class GamesController : Controller
	{
		private readonly ICategoryService categoryService;
		private readonly IDeviceService deviceservice;
		private readonly IGamesServices gameservice;

		public GamesController(ICategoryService _categoryService, IDeviceService _deviceservice, IGamesServices _gameservice)
		{
			categoryService = _categoryService;
			deviceservice = _deviceservice;
			gameservice = _gameservice;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult CreateGame()
		{
			CreateGameVM model = new CreateGameVM()
			{
				Categories = categoryService.GetCategoryes(),
				Devices = deviceservice.GetDevices(),
			};

			return View(model);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateGame(CreateGameVM model)
		{
			if (!ModelState.IsValid)
			{
				model.Categories = categoryService.GetCategoryes();
				model.Devices = deviceservice.GetDevices();
					return View(model);
			}
			await gameservice.CreateGame(model);
			return RedirectToAction(nameof(Index));
		}

		public override bool Equals(object? obj)
		{
			return obj is GamesController controller &&
				   EqualityComparer<IGamesServices>.Default.Equals(gameservice, controller.gameservice);
		}
	}
}
