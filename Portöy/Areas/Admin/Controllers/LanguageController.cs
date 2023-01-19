using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class LanguageController : Controller
    {
        LanguageManager language = new LanguageManager(new EfLanguageDal());
        
        public IActionResult Language()
        {
            var veri = language.list();
            return View(veri);
        }

        [HttpGet]
        public IActionResult LanguageAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LanguageAdd(LanguageAddModel p)
        {
            Language yeni = new Language()
            {
                LanguageImgUrl = p.LanguageImgUrl,
                LanguageName = p.LanguageName,
                LanguageStatus = true
            };
            language.ekle(yeni);
            return RedirectToAction("Language");
        }

        public IActionResult Delete(int id)
        {
            var silinen = language.IdGore(id);
            language.sil(silinen);
            return RedirectToAction("Language");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var veri = language.IdGore(id);
            return View(veri);
        }

        [HttpPost]
        public IActionResult Update(UpdateLanguageModel p)
        {
            Language yeni = new Language()
            {
                LanguageId = p.LanguageId,
                LanguageName = p.LanguageName,
                LanguageImgUrl = p.LanguageImgUrl,
                LanguageStatus = true,

            };
            language.güncelle(yeni);
            return RedirectToAction("Language");
        }
    }
}
