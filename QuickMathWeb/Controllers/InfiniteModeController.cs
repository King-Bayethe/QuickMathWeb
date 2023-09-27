using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuickMathWeb.Data;
using QuickMathWeb.Models.GameModels;

namespace QuickMathWeb.Controllers
{
    public class InfiniteModeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InfiniteModeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InfiniteModes
        public IActionResult InfiniteGame()
        {
            return View();
        }

    }
}
