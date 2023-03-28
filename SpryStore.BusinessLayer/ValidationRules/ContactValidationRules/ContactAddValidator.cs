using FluentValidation;
using SpryStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStore.BusinessLayer.ValidationRules.ContactValidationRules
{
    public class ContactAddValidator:AbstractValidator<Contact>
    {
        public ContactAddValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad Soyad alanını boş geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj alanını boş geçemezsiniz");
            RuleFor(y => y.Mail).NotEmpty().WithMessage("Mail alanını boş geçemezsiniz");
            RuleFor(x => x.NameSurname).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapın");
            RuleFor(z => z.Mail).MinimumLength(12).WithMessage("Lütfen daha uzun bir mail giriniz");
            RuleFor(x => x.NameSurname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapın");
            RuleFor(x => x.Mail).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız");
            RuleFor(x => x.MessageContent).MaximumLength(1000).WithMessage("Lütfen mesaj karakterini azaltın");
            //RuleFor(x => x.NameSurname).Equal("a").WithMessage("Lütfen içinde a harfi geçen bir isim girin");
        }
    }
}
