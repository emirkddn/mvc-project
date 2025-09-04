using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using mvcprojecttesting.Entity;
using mvcprojecttesting.Identity;
using mvcprojecttesting.Models;

namespace mvcprojecttesting.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);
            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>());
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid) {

                ApplicationUser user = new ApplicationUser();
                user.Name = model.Name;
                user.Email = model.Email;
                user.Surname = model.Surname;
                user.UserName = model.Username;

                IdentityResult result = UserManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    if (RoleManager.RoleExists("user"))
                    {    
                        UserManager.AddToRole(user.Id,"user");
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError","Kullanıcı Oluşturma Hatası");
                }
            }
            

            return View(model);
        }


        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = UserManager.Find(model.Username, model.Password);
                if (user != null)
                {
                    var authManager = HttpContext.GetOwinContext().Authentication;

                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;

                    authManager.SignIn(authProperties,identityclaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }


                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok!");
                }
            }


            return View(model);
        }


        // GET: Account
        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index","Home");
        }

    }
}