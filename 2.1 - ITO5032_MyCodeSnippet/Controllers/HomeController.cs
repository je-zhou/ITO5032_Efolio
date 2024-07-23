using ITO5032_MyCodeSnippet.Models;
using ITO5032_MyCodeSnippet.Models.Exercise;
using ITO5032_MyCodeSnippet.Models.HelloWorld;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITO5032_MyCodeSnippet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();

            ExampleDictionary ed = new ExampleDictionary();

            ed.Example();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
