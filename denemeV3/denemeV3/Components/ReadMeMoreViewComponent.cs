using denemeV3.Database;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;

namespace denemeV3.Components
{
    public class ReadMeMoreViewComponent : ViewComponent
    {
		public IViewComponentResult Invoke()
		{
			DatabaseContext context = Repos.app.ApplicationServices
					   .CreateScope().ServiceProvider
					   .GetRequiredService<DatabaseContext>();
			var x = context;
			var y = x.Haberler.ToList();
			var model = y.Take(y.Count - 15).Take(15).ToList();
			return View(model);
		}
	}
}
