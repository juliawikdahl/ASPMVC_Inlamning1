using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_inlamning.Controllers
{
    public class PageNotFound : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
