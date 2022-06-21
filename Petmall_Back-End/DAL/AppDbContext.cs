using Microsoft.EntityFrameworkCore;
using Petmall_Back_End.Models;

namespace Petmall_Back_End.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<HeaderIcon> HeaderIcons { get; set; }
    }
}
