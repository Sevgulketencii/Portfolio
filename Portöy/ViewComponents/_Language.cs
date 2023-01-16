using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents
{
    public class _Language:ViewComponent
    {
        LanguageManager language = new LanguageManager(new EfLanguageDal());
        public IViewComponentResult Invoke()
        {
            var list = language.list();
            return View(list);
        }
    }
}
