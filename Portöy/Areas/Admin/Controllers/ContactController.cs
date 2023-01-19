using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class ContactController : Controller
    {
        ContactManager contact = new ContactManager(new EfContactDal());
      
        public IActionResult Contact()
        {
            var veri = contact.list();
            return View(veri);
        }
    }
}
