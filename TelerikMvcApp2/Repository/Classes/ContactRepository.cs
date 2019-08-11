using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TelerikMvcApp2.Models;
using TelerikMvcApp2.Repository.Interfaces;

namespace TelerikMvcApp2.Repository.Classes
{
    public class ContactRepository:IContactRepository
    {
        private readonly ContactContext _context;
        
        public ContactRepository(ContactContext _context)
        {
            this._context = _context;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _context.Contacts.ToList();
        }

        public Contact GetContactById(int contactID)
        {
         return _context.Contacts.Find(contactID);
        }

        public void InsertContact(Contact contact)
        {
            _context.Contacts.Add(contact);
        }

        public void DeleteContact(int contactID)
        {
            var contact = _context.Contacts.Find(contactID);
            _context.Contacts.Remove(contact);
        }

        public void UpdateContact(Contact contact)
        {
            _context.Entry(contact).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}