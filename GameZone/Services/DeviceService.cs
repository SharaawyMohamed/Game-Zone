using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Services
{
	public class DeviceService:IDeviceService
	{
		private readonly GameDbContext context;

		public DeviceService(GameDbContext _context)
		{
			context = _context;
		}

		public IEnumerable<SelectListItem> GetDevices()
		{
			return context.Devices.
							Select(C => new SelectListItem
							{
								Value = C.Id.ToString(),
								Text = C.Name
							}).OrderBy(c => c.Text).AsNoTracking();
		}
	}
}
