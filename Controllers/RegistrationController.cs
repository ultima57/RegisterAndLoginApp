using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;

namespace RegisterAndLoginApp.Controllers {
    public class RegistrationController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult ProcessRegisration(UserModel userModel) {
            SecurityService securityService = new SecurityService();
            if (securityService.alreadyExsists(userModel)) {
                return View("RegistrationFailure", userModel);
            }
            else {
                return View("RegistrationSuccess", userModel);
            }
        }

    }
}
