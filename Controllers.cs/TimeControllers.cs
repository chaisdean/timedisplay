using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace time_display.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}