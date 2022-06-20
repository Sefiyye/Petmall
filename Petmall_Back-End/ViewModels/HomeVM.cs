using Petmall_Back_End.Models;
using System.Collections.Generic;

namespace Petmall_Back_End.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Slider { get; set; }
        public List<Category> Category { get; set; }
        public List<Seller> Seller { get; set; }
        public List<Carousel> Carousel { get; set; }
        public List<Icon> Icon { get; set; }
    }
}
