using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index(String name="Nabi Rasool",int numTimes=8)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

       

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
