using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contact = new ContactManager(new EfContactDal());

        public IActionResult Contact()
        {

            return View();
        }





        [HttpPost]
        public IActionResult Contact(ContactModel p)
        {
            Contact yeni = new Contact()
            {
                ContactName=p.ContactName,
                ContactSurname=p.ContactSurname,
                ContactMail=p.ContactMail,
                ContactTitle=p.ContactTitle,
                ContactMessage=p.ContactMessage,
                ContactStatus=true,
            };
            ContactValidator mv = new ContactValidator();
            ValidationResult result = mv.Validate(yeni);
            if (result.IsValid)
            {
                ViewBag.flag=1;
                contact.ekle(yeni);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("Index","Home");
        }
    }
}
