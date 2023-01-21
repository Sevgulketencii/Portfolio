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
    public class ProjectController : Controller
    {
        ProjectManager project = new ProjectManager(new EfProjectDal());


        public IActionResult Project()
        {
            var veri = project.list();

            return View(veri);
        }

        [HttpGet]
        public IActionResult ProjectAdd()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ProjectAdd(ProjectAddModel p)
        {
            Project yeni = new Project()
            {
                ProjectName = p.ProjectName,
                ProjectTitle = p.ProjectTitle,
                ProjectDescription = p.ProjectDesciription,
                ProjectDate = p.Date,
                ProjectImgUrl = p.ProjectImgUrl,
                ProjectStatus = true,
                ProjectUrl = p.ProjectUrl,
            };

            project.ekle(yeni);

            return RedirectToAction("Project");
        }

        public IActionResult Delete(int id)
        {
            var delete = project.IdGore(id);
            if (delete != null)
            {
                project.sil(delete);
                return RedirectToAction("Project");
            }
            return View();
        }


        public IActionResult StatuFalse(int id)
        {
            var stfalse = project.IdGore(id);
            if (stfalse != null)
            {
                stfalse.ProjectStatus = false;
                project.güncelle(stfalse);

            }
            return RedirectToAction("Project");
        }


        public IActionResult StatuTrue(int id)
        {
            var stTrue = project.IdGore(id);
            if (stTrue != null)
            {
                stTrue.ProjectStatus = true;
                project.güncelle(stTrue);

            }
            return RedirectToAction("Project");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var veri = project.IdGore(id);
            

            return View(veri);
        }


        [HttpPost]
        public IActionResult Update(UpdateProjectModel p)
        {
            var guncellen = project.IdGore(p.ProjectId);
            guncellen.ProjectName = p.ProjectName;
            guncellen.ProjectTitle = p.ProjectTitle;
            guncellen.ProjectDescription = p.ProjectDesciription;
            guncellen.ProjectDate = p.Date;
            guncellen.ProjectImgUrl = p.ProjectImgUrl;
            guncellen.ProjectUrl = p.ProjectUrl;
            guncellen.ProjectStatus = true;
            project.güncelle(guncellen);


            return RedirectToAction("Project");
        }

    }

}
