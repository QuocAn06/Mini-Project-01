using ContactManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp.Services
{
    public class ContactManager
    {
        private List<Contact> contacts = new List<Contact>();

        public List<Contact> listContacts => contacts;

        // Add Contact method
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        // Search Contact method
        public List<Contact> SearchByName(string keyword)
        {
            var results = contacts.Where(c => c.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        public List<Contact> SearchByPhone(string keyword)
        {
            var results = contacts.Where(c => c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        public List<Contact> SearchByEmail(string keyword)
        {
            var results = contacts.Where(c => c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        // Delete Contact method

        // Load Contacts From File CSV method (string path)

        // Save Contacts To File CSV method (string path)

    }
}
