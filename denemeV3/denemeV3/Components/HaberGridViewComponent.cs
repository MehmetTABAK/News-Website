using denemeV3.Database;

using Microsoft.AspNetCore.Mvc;

using System.Linq;

namespace denemeV3.Components
{
	public class HaberGridViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(API.GetHaberList().TakeLast(15).Reverse().ToList());
		}
	}
}
