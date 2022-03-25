using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_inlamning.Controllers
{
    public class Contacts : Controller

    {
        [Route("contact")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
