using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.ViewComponents
{
    public class _HomeContact : ViewComponent
    {
        ContactManager contact = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var veri = contact.list();
            return View(veri);
        }
    }
}
