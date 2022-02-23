using Microsoft.AspNetCore.Mvc;

namespace ExampleTestProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
