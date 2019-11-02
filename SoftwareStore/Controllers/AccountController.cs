using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SoftwareStore.Models.Concrete.Identity;

namespace SoftwareStore.Controllers
{
    public class AccountController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Checkout1()
        {
            return View();
        }
        public IActionResult Checkout2()
        {
            return View();
        }
        public IActionResult Checkout3()
        {
            return View();
        }
        public IActionResult Checkout4()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDefaultUser(ApplicationUser user)
        {
            if (true)
            {
                //if (!await UserManager.IsInRoleAsync(user.Id, "Member"))
                await _userManager.AddToRoleAsync(user, "Member");

                return View("Index");
            }
        }
    }
}
