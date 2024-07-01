using GameZone.VMS;

namespace GameZone.Services
{
	public interface IGamesServices
	{
		public Task CreateGame(CreateGameVM model);
	}
}
