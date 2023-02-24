using denemeV3.Database;
using denemeV3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;

namespace denemeV3.Components
{
    public class TampleteViewComponent : ViewComponent
    {
		public IViewComponentResult Invoke()
		{
			DatabaseContext context = Repos.app.ApplicationServices
					   .CreateScope().ServiceProvider
					   .GetRequiredService<DatabaseContext>();
			var x = context;
			var y = x.Haberler.ToList().Take(4).ToList();
			return View(y);
		}
	}
}
