using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("Ad Boş Geçilemez");
            RuleFor(x => x.ContactSurname).NotEmpty().WithMessage("Soyad Boş Geçilemez");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Mail Boş Geçilemez");
            RuleFor(x => x.ContactTitle).NotEmpty().WithMessage("Başlık Boş Geçilemez");
            RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Mesaj İçeriği Boş Geçilemez");
        }
    }
}
