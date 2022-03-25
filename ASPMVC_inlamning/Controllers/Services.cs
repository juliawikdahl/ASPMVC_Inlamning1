using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_inlamning.Controllers
{
    public class Services : Controller
    {
        [Route("service")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
