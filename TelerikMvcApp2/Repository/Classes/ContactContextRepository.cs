using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TelerikMvcApp2.Models;
using TelerikMvcApp2.Repository.Interfaces;

namespace TelerikMvcApp2.Repository.Classes
{
    public class ContactContextRepository : DbContext,IContactContextRepository
    {

        public DbSet<Contact> Contacts { get; set; }
        public void Save()
        {
            base.SaveChanges();
        }

        public void Update(Contact contact)
        {
            base.Entry(contact).State = EntityState.Modified;
        }

    }
}