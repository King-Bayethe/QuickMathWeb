using Microsoft.AspNetCore.Mvc;

namespace QuickMathWeb.Controllers
{
    public class PracticeModeController : Controller
    {
        public IActionResult PracticeGame()
        {
            return View();
        }
        public IActionResult PracticeSetup()
        {
            return View();
        }

    }
}
