using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        AboutManager about = new AboutManager(new EfAboutDal());
       
        [HttpGet]
        public IActionResult About()
        {
            var veri = about.list().Where(x => x.AboutStatus == true).FirstOrDefault();
            return View(veri);
        }

        [HttpPost]
        public IActionResult About(AboutUpdateModel p)
        {
            About yeni = new About()
            {
                Name = p.Name,
                Surname = p.Surname,
                Mail = p.Mail,
                ImgUrl = p.ImgUrl,
                BirthDay = p.BirthDay,
                Phone = p.Phone,
                WorkingYear = p.WorkingYear,
                AboutDesciription = p.AboutDesciription,
                AboutStatus = true,
                AboutTitle = p.AboutTitle,
                AboutId=p.id
            };
            return View(yeni);
        }
    }
}
