using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "My first ASP.NET CORE Application";
        }
    }
}
