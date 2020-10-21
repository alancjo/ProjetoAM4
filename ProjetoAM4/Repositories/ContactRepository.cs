using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjetoAM4.Context;
using ProjetoAM4.Models;

namespace ProjetoAM4.Repositories
{
    internal class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _context;

        public ContactRepository(AppDbContext contexto) => _context = contexto;

        public bool Create(Contact contact)
        {
            contact.RegistrationDate = DateTime.Now;
            contact.UpdateDate = null;

            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return true;
        }

        public void Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            contact.Excluded = true;
            contact.UpdateDate = DateTime.Now;

            _context.Entry(contact).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public List<Contact> GetAll()
        {

            return _context.Contacts.Where(e => !e.Excluded).ToList();

        }

        public Contact GetDetails(int id)
        {
            return _context.Contacts.Where(e => e.ContactId == id && !e.Excluded).FirstOrDefault();
        }

    }
}
