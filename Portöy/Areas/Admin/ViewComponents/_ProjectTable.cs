using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.ViewComponents
{
    public class _ProjectTable : ViewComponent
    {
        ProjectManager project = new ProjectManager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var veri = project.list();
            return View(veri);
        }
    }
}
