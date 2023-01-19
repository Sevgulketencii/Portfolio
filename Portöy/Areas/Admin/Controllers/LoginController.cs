using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {

        AdminManager admin=new AdminManager(new EfAdminDal());

        
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Giris(SingInModel p)
        {
            var giris = admin.Login();

            if(giris.pasword==p.sifre && giris.username == p.kullaniciAdi)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.kullaniciAdi)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }
            
            return RedirectToAction("SignIn");
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home", new { area = "" });
            
        }
    }
}
