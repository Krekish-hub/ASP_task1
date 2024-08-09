using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAppProduct.Models;
using WebAppProduct.Models.DB;

namespace WebAppProduct.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = _context.Products
                                   .Include(p => p.Category)
                                   .ToListAsync();
            return View(await products);
        }
    }
}
