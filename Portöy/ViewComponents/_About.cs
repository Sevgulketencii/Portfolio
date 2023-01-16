using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents._Hakkimda
{
    public class _About : ViewComponent
    {
        AboutManager veri = new AboutManager(new EfAboutDal());
        
        public IViewComponentResult Invoke()
        {
            var list=veri.list();
            return View(list);
        }
    }
}
