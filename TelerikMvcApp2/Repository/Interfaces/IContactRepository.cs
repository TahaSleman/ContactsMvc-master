using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikMvcApp2.Models;

namespace TelerikMvcApp2.Repository.Interfaces
{
   public interface IContactRepository
    {
        IEnumerable<Contact> GetContacts();
        Contact GetContactById(int contactId);
        void InsertContact(Contact contact);
        void DeleteContact(int contactID);
        void UpdateContact(Contact contact);
        void Save();
    }
}
