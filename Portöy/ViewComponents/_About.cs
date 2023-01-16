using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents._Hakkimda
{
    public class _About : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
