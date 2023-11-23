using DZ_231123_Reviews_Repos_and_Sessions_.Models;
using DZ_231123_Reviews_Repos_and_Sessions_.Repos;
using Microsoft.AspNetCore.Mvc;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Controllers
{
    public class AccountController : Controller
    {
        private IRepository repo;

        public AccountController(IRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult EnterAsGuest()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("login") == null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                bool isSucceededLogin = await repo.TryToLogin(loginVM);
                if (isSucceededLogin)
                {
                    HttpContext.Session.SetString("login", loginVM.Login);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неправильний логін або пароль");
                }
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                bool isSucceededRegister = await repo.TryToRegister(registerVM);
                if (isSucceededRegister)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    ModelState.AddModelError("Login", "Такий логін вже зайнятий");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}
