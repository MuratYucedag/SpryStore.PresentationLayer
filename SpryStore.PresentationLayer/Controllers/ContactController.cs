using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SpryStore.BusinessLayer.Abstract;
using SpryStore.BusinessLayer.ValidationRules.ContactValidationRules;
using SpryStore.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStore.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addcontact(Contact contact)
        {
            ContactAddValidator validationRules = new ContactAddValidator();
            ValidationResult result = validationRules.Validate(contact);
            if (result.IsValid)
            {
                contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
                _contactService.TInsert(contact);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
