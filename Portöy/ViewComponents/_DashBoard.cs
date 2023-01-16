using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents
{
    public class _DashBoard: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
