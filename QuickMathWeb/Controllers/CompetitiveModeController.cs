
using Microsoft.AspNetCore.Mvc;

namespace QuickMathWeb.Controllers
{
	public class CompetitiveModeController : Controller
	{
		public IActionResult FiniteGame()
		{
			return View();
		}
	}
}
