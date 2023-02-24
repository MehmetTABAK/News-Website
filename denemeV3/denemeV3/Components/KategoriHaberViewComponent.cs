using denemeV3.Database;
using denemeV3.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;

namespace denemeV3.Components
{
	public class KategoriHaberViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(int kategori)
		{
			var kat = ((Kategoriler)kategori);
			DatabaseContext context = Repos.app.ApplicationServices
					.CreateScope().ServiceProvider
					.GetRequiredService<DatabaseContext>();
			var x = context;
			var y = x.Haberler.Where(x=> x.Kategori == kat).ToList();
			return View(y);
		}
	}
}
