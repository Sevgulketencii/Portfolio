using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.ViewComponents
{
    public class _UserData : ViewComponent
    {
        AboutManager about = new AboutManager(new EfAboutDal());
        ProjectManager project = new ProjectManager(new EfProjectDal());
        CertificateManager certificate = new CertificateManager(new EfCertificateDal());
        LanguageManager language = new LanguageManager(new EfLanguageDal());
        public IViewComponentResult Invoke()
        {
            ViewBag.deneyim = about.list().Select(x => x.WorkingYear).FirstOrDefault();
            ViewBag.projectCount = project.list().Count();
            ViewBag.certificateCount = certificate.list().Count();
            ViewBag.languageCount = language.list().Count();
            return View();
        }
    }
}
