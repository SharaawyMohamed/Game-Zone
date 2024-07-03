using GameZone.Core.Models;
using GameZone.VMS;

namespace GameZone.Services
{
	public interface IGamesServices
	{
		public Task CreateGame(CreateGameVM model);
		public IEnumerable<Game> GetAllGames();
	}
}
