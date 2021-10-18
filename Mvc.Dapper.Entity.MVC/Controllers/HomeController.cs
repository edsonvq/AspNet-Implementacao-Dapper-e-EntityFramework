using Mvc.Dapper.Entity.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mvc.Dapper.Entity.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() =>
            View();

        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
