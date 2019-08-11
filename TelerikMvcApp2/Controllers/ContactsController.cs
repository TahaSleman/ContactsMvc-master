using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TelerikMvcApp2.Models;
using TelerikMvcApp2.Repository.Classes;
using TelerikMvcApp2.Repository.Interfaces;

namespace TelerikMvcApp2.Controllers
{
    public class ContactsController : Controller
    {

        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository _contactRepository)
        {
            this._contactRepository = _contactRepository;
        }

        // GET: Contacts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View("ContactForm", new Contact());
        }


        public ActionResult Edit(int id)
        {
           var contactInDb = _contactRepository.GetContactById(id);
               //  contactRepository.Save();
            return View("ContactForm", contactInDb);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, Contact contact)
        {
           
                _contactRepository.DeleteContact(contact.Id);
                _contactRepository.Save();
            

            return Json(new[] { contact }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Save(Contact contact)
        {
            if (!ModelState.IsValid) return View("ContactForm");
            if (contact.Id == 0)
            {
              _contactRepository.InsertContact(contact);
            }
            else
            {
                  _contactRepository.UpdateContact(contact);
              
            }
            _contactRepository.Save();
            return RedirectToAction("Index", "Contacts");

        }

        public ActionResult GetContacts([DataSourceRequest] DataSourceRequest request)
        {
            var contacts = _contactRepository.GetContacts();
            return Json(contacts.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

    }
}