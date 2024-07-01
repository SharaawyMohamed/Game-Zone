using GameZone.Core.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameZone.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly GameDbContext context;
		public CategoryService(GameDbContext _context)
		{
			context = _context;
		}
		public IEnumerable<SelectListItem> GetCategoryes()
		{
			return context.Categories.
				Select(C => new SelectListItem
				{
					Value = C.Id.ToString(),
					Text = C.Name
				}).OrderBy(c => c.Text).AsNoTracking();
		}

		
	}
}
