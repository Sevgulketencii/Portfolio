using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents
{
    public class _Project: ViewComponent
    {
        ProjectManager project = new ProjectManager(new EfProjectDal());
        public IViewComponentResult Invoke()
        {
            var list = project.list();
            return View(list);
        }
    }
}
