using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents
{
    public class _DashBoard: ViewComponent
    {
        AboutManager about = new AboutManager(new EfAboutDal());
       
        public IViewComponentResult Invoke()
        {
            var veri = about.list();
            return View(veri);
        }
    }
}
