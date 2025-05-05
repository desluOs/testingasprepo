using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;

namespace GroupProject.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }
    }
}
