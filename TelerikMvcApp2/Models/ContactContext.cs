using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TelerikMvcApp2.Models
{
    public class ContactContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public ContactContext()
        {
                
        }    
    }
}