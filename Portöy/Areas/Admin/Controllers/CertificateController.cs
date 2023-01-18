using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CertificateController : Controller
    {
        CertificateManager certificate = new CertificateManager(new EfCertificateDal());

        public IActionResult Certificate()
        {
            var veri = certificate.list();
            return View(veri);
        }
    
        [HttpGet]
        public IActionResult CertificateAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CertificateAdd(CertificateAddModel p)
        {
            Certificate yeni = new Certificate()
            {
                
                CertificateName = p.CertificateName,
                Company = p.CertificateCompany,
                CertificateUrl = p.CertificateImgUrl,
                CertificateImgUrl = p.CertificateImgUrl,
                CertificateStatus=true,
                
            };
            
            certificate.ekle(yeni);
            return RedirectToAction("Certificate");
        }


        public IActionResult Delete(int id)
        {
            var silinen = certificate.IdGore(id);
            certificate.sil(silinen);
            return RedirectToAction("Certificate");
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var guncellenen = certificate.IdGore(id);
            ViewBag.statu = guncellenen.CertificateStatus;
            return View(guncellenen);
        }


        [HttpPost]
        public IActionResult Update(CertificateUpdateModel p)
        {
            Certificate guncel = new Certificate()
            {
                CertificateId = p.CertificateId,
                CertificateName = p.CertificateName,
                CertificateUrl = p.CertificateUrl,
                CertificateImgUrl = p.CertificateImgUrl,
                Company = p.Company,
                CertificateStatus = true
                
            };
            certificate.güncelle(guncel);
            return RedirectToAction("Certificate");
        }

    }
}
