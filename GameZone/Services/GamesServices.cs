using GameZone.Core.Models;
using GameZone.Settings;
using GameZone.VMS;

namespace GameZone.Services
{
	public class GamesServices : IGamesServices
	{
		private readonly GameDbContext context;
		private readonly IWebHostEnvironment webhostenvironment;
		private readonly string ImagePath;
		public GamesServices(GameDbContext _context, IWebHostEnvironment _webhostenvironment)
		{
			context = _context;
			webhostenvironment = _webhostenvironment;
			ImagePath = $"{webhostenvironment.WebRootPath}{FileSettings.ImagePath}";// == path wwwroot
		}

		public async Task CreateGame(CreateGameVM model)
		{
			var CoverName = $"{Guid.NewGuid()}{Path.GetExtension(model.Cover.FileName)}";
			var CoverPath = Path.Combine(ImagePath,CoverName);
			using var Stream = File.Create(CoverPath);
			await model.Cover.CopyToAsync(Stream);
			Stream.Dispose();
			// Mapping
			Game game = new Game()
			{
				Name = model.Name,
				CatId = model.CategoryId,
				Cover = CoverName,
				Description = model.Description,
				Devices = model.SelectedDevices.Select(D => new GameDevice() { DeviceId = D }).ToList()

			};

			context.Add(game);
			context.SaveChanges();
		}

		public  IEnumerable<Game> GetAllGames()
		{
			return  context.Games.Include(c=>c.Categoriy).Include(c=>c.Devices).ThenInclude(d=>d.Device).AsNoTracking().OrderBy(g=>g.Name).ToList();
		}
	}
}
