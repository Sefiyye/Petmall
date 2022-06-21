using Petmall_Back_End.Models;
using System.Collections.Generic;

namespace Petmall_Back_End.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Seller> Sellers { get; set; }
        public List<Carousel> Carousels { get; set; }
        public List<Icon> Icons { get; set; }
        public Setting Settings { get; set; }
        public List<HeaderIcon> HeaderIcons { get; set; }
    }
}
