using Microsoft.AspNetCore.Mvc;

namespace Petmall_Back_End.Areas.PetmallAdmin.Controllers
{
    public class DashoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
