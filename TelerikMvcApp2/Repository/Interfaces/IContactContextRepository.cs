using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikMvcApp2.Models;

namespace TelerikMvcApp2.Repository.Interfaces
{
   public interface IContactContextRepository
    {
        DbSet<Contact> Contacts { get; set; }
        void Save();
        void Update(Contact contact);
    }
}
