using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.ViewComponents
{
    public class _Widgets: ViewComponent
    {
        CertificateManager certificate = new CertificateManager(new EfCertificateDal());
        ProjectManager project = new ProjectManager(new EfProjectDal());
        LanguageManager language = new LanguageManager(new EfLanguageDal());
        AboutManager about = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            ViewBag.certificateCount = certificate.list().Count();
            ViewBag.projectCount = project.list().Count();
            ViewBag.languageCount = language.list().Count();
            ViewBag.workingYear = about.list().Select(x => x.WorkingYear).FirstOrDefault();
            return View();
        }
    }
}
