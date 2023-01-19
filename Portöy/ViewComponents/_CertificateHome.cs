using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents
{
    public class _CertificateHome : ViewComponent
    {
        CertificateManager certificate = new CertificateManager(new EfCertificateDal());
        public IViewComponentResult Invoke()
        {
            var veri = certificate.list();
            return View(veri);
        }
    }
}
