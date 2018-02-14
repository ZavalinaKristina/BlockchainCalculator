using ITUniver.Calc.DB.Modules;
using ITUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebCalc.Models;

namespace WebCalc.Controllers
{

    [Authorize]
    public class AccountController : Controller
    {
        private IUserRepository Users { get; set; }

        public AccountController()
        {
            Users = new UserRepository();
        }

        // GET: Account
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View();

            if (Users.Check(model.Login, model.Password))
            {
                //поставить отметку об аутентификации
                FormsAuthentication.SetAuthCookie(model.Login, true);
                return RedirectToAction("Index", "Calc");
            }

            ModelState.AddModelError("", "Не удалось выполнить вход");
            return View();

        }
        public void Logout()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Registration(LoginModel model)
        {
           if (!Users.Check(model.Login, model.Password))
            {
                var user = new User();
                user.Login = model.Login;
                user.Password = model.Password;
                user.Name = model.Name;
                user.Sex = model.Sex;
                Users.Save(user);
                return View();
            }
           return View();
        }
    }
}