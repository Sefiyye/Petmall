using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petmall_Back_End.DAL;
using Petmall_Back_End.ViewModels;
using System.Threading.Tasks;

namespace Petmall_Back_End.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Category = await _context.Categories.ToListAsync(),
                Slider = await _context.Sliders.ToListAsync(),
                Seller = await _context.Sellers.ToListAsync(),
                Carousel = await _context.Carousels.ToListAsync(),
                Icon = await _context.Icons.ToListAsync(), 
            };
            return View(model);
        }
    }
}
