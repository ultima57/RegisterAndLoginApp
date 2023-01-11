using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RegisterAndLoginApp.Controllers {
    public class MessengerController : Controller {
        [Authorize]
        public IActionResult Index() {
            return View();
        }
    }
}
