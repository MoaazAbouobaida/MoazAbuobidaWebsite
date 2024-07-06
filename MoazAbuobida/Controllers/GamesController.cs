using Microsoft.AspNetCore.Mvc;

namespace MoazAbuobida2dGames.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
