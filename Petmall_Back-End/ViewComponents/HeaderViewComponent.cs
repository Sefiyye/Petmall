using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petmall_Back_End.DAL;
using Petmall_Back_End.ViewModels;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Petmall_Back_End.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM model = new HomeVM
            {
                Settings = await _context.Settings.FirstOrDefaultAsync(),
                HeaderIcons = await _context.HeaderIcons.ToListAsync()
            };
            return View(model);
        }
    }
}

