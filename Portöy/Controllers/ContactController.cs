using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contact = new ContactManager(new EfContactDal());

        [HttpPost]
        public IActionResult Contact(Contact p)
        {
            contact.ekle(p);
            return RedirectToAction("Index","Home");
        }
    }
}
