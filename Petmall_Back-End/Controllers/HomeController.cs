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
                Categories = await _context.Categories.ToListAsync(),
                Sliders = await _context.Sliders.ToListAsync(),
                Sellers = await _context.Sellers.ToListAsync(),
                Carousels = await _context.Carousels.ToListAsync(),
                Icons = await _context.Icons.ToListAsync(), 
                HeaderIcons = await _context.HeaderIcons.ToListAsync(),
                Settings = await _context.Settings.FirstOrDefaultAsync(),
            };
            return View(model);
        }
    }   
}
