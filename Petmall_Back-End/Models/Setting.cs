using System.Collections.Generic;

namespace Petmall_Back_End.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string FooterImage { get; set; }

        public List<HeaderIcon> HeaderIcons { get; set; }
    }
}
