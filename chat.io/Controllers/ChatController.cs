using Microsoft.AspNetCore.Mvc;

namespace chat.io.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
